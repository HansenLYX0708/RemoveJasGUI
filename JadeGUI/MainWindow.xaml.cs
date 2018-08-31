using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Threading;

using ViewModel;

namespace JadeGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AmberViewModel _AmberMachine;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Left = 0;
            //this.Top = 0;
            //this.Height = SystemParameters.WorkArea.Height;
            //this.Width = SystemParameters.WorkArea.Width;
            _AmberMachine = new AmberViewModel();
            leftGrid.DataContext = _AmberMachine.CommonInfo;
            FuncTabControl.DataContext = _AmberMachine.PageEnableControl;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {

                DragMove();
            }
        }

        private void BtnClose_click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnMinimized_click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnMaximized_click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Really Exit?", "Message", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private delegate void SetprogressBarHandle(int vaule);

        private void Btn_BladeDoubleClick(object sender, RoutedEventArgs e)
        { }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Test Add Capability
            //MachineCapability a = new MachineCapability { Name = "test", Description = "test1", Value = "Test1" };
            //this.Capabilities.Add(a);

            // Test ProgressBar
            //MyProgressBar.Visibility = Visibility.Visible;
            //mThread = new Thread(ThreadProcess);
            //MyProgressBar.Maximum = 10;
            //MyProgressBar.Value = 0;
            //mThread.Name = "test test";
            //mThread.Start();

            _AmberMachine.m_Blades[0].Name = "Blade1";

            myPerprotyGrid.Refresh();

        }
        
        private void Btn_BladeClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "Blade1":
                    myPerprotyGrid.Instance = _AmberMachine.m_Blades[0];
                    break;
                case "Blade2":
                    myPerprotyGrid.Instance = _AmberMachine.m_Blades[1];
                    break;
                case "Blade3":
                    myPerprotyGrid.Instance = _AmberMachine.m_Blades[2];
                    break;
                case "Blade4":
                    myPerprotyGrid.Instance = _AmberMachine.m_Blades[3];
                    break;
                case "Blade5":
                    myPerprotyGrid.Instance = _AmberMachine.m_Blades[4];
                    break;
                default:
                    break;
            }
        }

        private void Btn_TrayClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "Tray1":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[0];
                    break;
                case "Tray2":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[1];
                    break;
                case "Tray3":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[2];
                    break;
                case "Tray4":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[3];
                    break;
                case "Tray5":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[4];
                    break;
                case "Tray6":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[5];
                    break;
                case "Tray7":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[6];
                    break;
                case "Tray8":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[7];
                    break;
                case "Tray9":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[8];
                    break;
                case "Tray10":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[9];
                    break;
                case "Tray11":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[10];
                    break;
                case "Tray12":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[11];
                    break;
                case "Tray13":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[12];
                    break;
                case "Tray14":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[13];
                    break;
                default:
                    break;
            }
        }

        private void Btn_PickerClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "Picker1":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[0];
                    break;
                case "Picker2":
                    myPerprotyGrid.Instance = _AmberMachine.m_Trays[1];
                    break;
                default:
                    break;
            }
        }
    }
}
