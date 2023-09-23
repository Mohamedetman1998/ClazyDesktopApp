using ClazyDesktop.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MenuItem = System.Windows.Controls.MenuItem;
using ClazyNavis.View;
using WindowsFormsHost;

namespace ClazyDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            switch (((MenuItem)sender).Uid)
            {
                case "0": ThemesController.SetTheme(ThemeType.DeepDark); break;
                case "1": ThemesController.SetTheme(ThemeType.SoftDark); break;
                case "2": ThemesController.SetTheme(ThemeType.DarkGreyTheme); break;
                case "3": ThemesController.SetTheme(ThemeType.GreyTheme); break;
                case "4": ThemesController.SetTheme(ThemeType.LightTheme); break;
                case "5": ThemesController.SetTheme(ThemeType.RedBlackTheme); break;
            }

            e.Handled = true;
        }
        //public void HostNavisworksPlugin()
        //{
        //    // Create an instance of the Windows Forms UserControl
        //    WinFormsUserControl winFormsControl = new WinFormsUserControl();

        //    // Set the Windows Forms UserControl as the child of the WindowsFormsHost
        //    windowsFormsHost.Child = winFormsControl;

        //    // Now, create an instance of your Navisworks plugin window
        //    ChoiceWindow navisworksControl = new ChoiceWindow();

        //    // Show the Navisworks plugin window
        //    navisworksControl.ShowDialog();
        //}


    }
}
