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
using ClazyNavis;
using System;

namespace ClazyDesktop.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region PropChanging&Spinner

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
        #endregion

        public string nwfpath { get; set; } 

        public Command InsertNwc { get; set; }
        public Command NextCommand { get; set; }
        public static NavisworksApplication navisworksApplication { get; set; }

        public string ProjName { get; set; }

        public MainViewModel()
        {
            navisworksApplication = new NavisworksApplication();
            navisworksApplication.Visible = false;

            IsSpinnerVisible = false;
            InsertNwc = new Command(ExecuteInsertNwc);
            NextCommand = new Command(ExecuteNextCommand);
        }

        public void ExecuteNextCommand(object parameter)
        {
            Window w1 = parameter as Window;

            // Close the window
            w1.Close();
            navisworksApplication.ExecuteAddInPlugin("Clazy.Etman", ProjName);

            // Execute the plugin
        }


        public async void ExecuteInsertNwc(object parameter)
        {
            ProjName = parameter as string;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "NWC Files (*.nwc)|*.nwc",
                Multiselect = true
            };

            bool? openFileDialogResult = await Application.Current.Dispatcher.InvokeAsync(() => openFileDialog.ShowDialog());

            if (openFileDialogResult != true)
            {
                // No files selected or user canceled
                return;
            }

            isSpinnerVisible = true;

            var nwcs = openFileDialog.FileNames;

            try
            {
                // Create NavisworksApplication instance on a background thread
                await Application.Current.Dispatcher.InvokeAsync(()=>
                {
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

                SaveFileDialog saveNWF = new SaveFileDialog
                {
                    Filter = "NWF Files (*.nwf)|*.nwf"
                };

                bool? saveNWFDialogResult = await Application.Current.Dispatcher.InvokeAsync(() => saveNWF.ShowDialog());

                if (saveNWFDialogResult == true)
                {
                    nwfpath = saveNWF.FileName;
                    // Continue with your logic...
                }
            }
            finally
            {
                // Perform any cleanup or finalization here
            }
        }


    }
}
