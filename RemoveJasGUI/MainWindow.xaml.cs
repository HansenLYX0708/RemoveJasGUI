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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MachineCapability a = new MachineCapability { Name = "test", Description = "test1", Value = "Test1" };
            this.Capabilities.Add(a);
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
