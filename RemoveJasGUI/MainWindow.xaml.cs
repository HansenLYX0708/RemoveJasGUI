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

namespace RemoveJasGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MachineCapability> Capabilities { get; } = new ObservableCollection<MachineCapability>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            var capabilities = new CapabilityRepository().GetCapability();
            foreach (var capability in capabilities)
            {
                this.Capabilities.Add(capability);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Height = SystemParameters.WorkArea.Height;
            this.Width = SystemParameters.WorkArea.Width;
            MyProgressBar.Visibility = Visibility.Hidden;

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
            this.Close();
            
        }

        private void BtnMinimized_click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnMaximized_click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
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

        private delegate void SetprogressBarHandle(int vaule);    //定义 代理函数 
        private void SetprogressBar(int vaule)
        {
            if (this.Dispatcher.Thread != System.Threading.Thread.CurrentThread)
            {
                this.Dispatcher.Invoke(new SetprogressBarHandle(this.SetprogressBar), vaule);
            }
            else
            {
                MyProgressBar.Value = vaule;
                if (MyProgressBar.Value >= 10)
                {
                    MyProgressBar.Visibility = Visibility.Hidden;
                }
            }
        }

        private void ThreadProcess(object obj)
        {
            int i = 0;
            while (true)
            {
                i++;
                if (i > 10)
                {
                    i = 0;
                }
                SetprogressBar(i);
                Thread.Sleep(1000);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Test Add Capability
            //MachineCapability a = new MachineCapability { Name = "test", Description = "test1", Value = "Test1" };
            //this.Capabilities.Add(a);

            // Test ProgressBar
            MyProgressBar.Visibility = Visibility.Visible;
            Thread mThread = new Thread(ThreadProcess);
            MyProgressBar.Maximum = 10;
            MyProgressBar.Value = 0;
            mThread.Name = "线程测试";
            mThread.Start();
        }
    }

    public sealed class MachineCapability
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }

    public sealed class CapabilityRepository
    {
        private static IEnumerable<MachineCapability> s_Capability;

        public IEnumerable<MachineCapability> GetCapability() =>
          s_Capability ?? (s_Capability = new List<MachineCapability>
          {
              new MachineCapability { Name="ABS", Description = "Test", Value= "test" },
              new MachineCapability { Name="BHS", Description = "Test", Value= "test" },
              new MachineCapability { Name="LEOMS", Description = "Test", Value= "test" },
              new MachineCapability { Name="LEO_", Description = "Test", Value= "test" }
          });
    }
}
