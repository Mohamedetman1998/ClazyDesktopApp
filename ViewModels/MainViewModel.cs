using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Autodesk.Navisworks.Api.Automation;
using ClazyDesktop.Utilities;
using Microsoft.Win32;
using Themes.ViewModels.DataGrids;

namespace ClazyDesktop.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool isSpinnerVisible;
        public bool IsSpinnerVisible
        {
            get { return isSpinnerVisible; }
            set
            {
                if (isSpinnerVisible != value)
                {
                    isSpinnerVisible = value;
                    OnPropertyChanged(nameof(IsSpinnerVisible));
                }
            }
        }

        string nwfpath = "";

        public Command InsertNwc { get; set; }

        public MainViewModel()
        {
            IsSpinnerVisible = false;
            InsertNwc = new Command(ExecuteInsertNwc);
        }

        public async void ExecuteInsertNwc(object parameter)
        {
            Window w1 = parameter as Window;

            // Show the spinner
            await w1.Dispatcher.InvokeAsync(() => IsSpinnerVisible = true);

            OpenFileDialog openFileDialog = null;
            bool? openFileDialogResult = false;

            await w1.Dispatcher.InvokeAsync(() =>
            {
                openFileDialog = new OpenFileDialog
                {
                    Filter = "NWC Files (*.nwc)|*.nwc",
                    Multiselect = true
                };

                openFileDialogResult = openFileDialog.ShowDialog(w1);
            });

            if (openFileDialogResult != true)
            {
                // No files selected or user canceled
                await w1.Dispatcher.InvokeAsync(() => IsSpinnerVisible = false); // Hide the spinner
                return;
            }

            var nwcs = openFileDialog.FileNames;

            NavisworksApplication navisworksApplication = null;

            try
            {
                // Create NavisworksApplication instance on a background thread
                await Task.Run(() =>
                {
                    navisworksApplication = new NavisworksApplication();
                    navisworksApplication.Visible = false;

                    foreach (var item in nwcs)
                    {
                        navisworksApplication.AppendFile(item);
                    }
                });

                // Ensure the NavisworksApplication instance is ready
                if (navisworksApplication == null)
                {
                    // Handle the case where the instance creation failed
                    return;
                }

                // Use the NavisworksApplication instance here

                SaveFileDialog saveNWF = null;
                bool? saveNWFDialogResult = false;

                await w1.Dispatcher.InvokeAsync(() =>
                {
                    saveNWF = new SaveFileDialog
                    {
                        Filter = "NWF Files (*.nwf)|*.nwf"
                    };

                    saveNWFDialogResult = saveNWF.ShowDialog(w1);
                });

                if (saveNWFDialogResult == true)
                {
                    var nwfpath = saveNWF.FileName;

                    // Close the parent window before saving (assuming you want to close it)
                    await w1.Dispatcher.InvokeAsync(() => w1.Close());

                    // Save and dispose
                 
                }

                // Execute plugin
                await Task.Run(() =>
                {
                    navisworksApplication.ExecuteAddInPlugin("ITI GraduationProject.FinalClashAuto");
                });

                await Task.Run(() =>
                {
                    navisworksApplication.SaveFile(nwfpath);

                    // Dispose the NavisworksApplication instance
                    navisworksApplication.Dispose();
                });
            }
            finally
            {
                // Hide the spinner
                await w1.Dispatcher.InvokeAsync(() => IsSpinnerVisible = false);
            }
        }
    }
}
