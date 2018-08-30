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
        private System.Windows.Forms.PropertyGrid OptionsPropertyGrid;
        public AmberViewModel _AmberMachine;

        //public ObservableCollection<MachineCapability> Capabilities { get; } = new ObservableCollection<MachineCapability>();
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = this;
            //var capabilities = new CapabilityRepository().GetCapability();
            //foreach (var capability in capabilities)
            //{
            //    this.Capabilities.Add(capability);
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Height = SystemParameters.WorkArea.Height;
            this.Width = SystemParameters.WorkArea.Width;
            _AmberMachine = new AmberViewModel();
            leftGrid.DataContext = _AmberMachine.CommonInfo;
            FuncTabControl.DataContext = _AmberMachine.PageEnableControl;
        }

        public class AppSettings
        {
            private bool saveOnClose = true;
            private string greetingText = "欢迎使用应用程序！";
            private int itemsInMRU = 4;
            private int maxRepeatRate = 10;
            private bool settingsChanged = false;
            private string appVersion = "1.0";

            public bool SaveOnClose
            {
                get { return saveOnClose; }
                set { saveOnClose = value; }
            }
            public string GreetingText
            {
                get { return greetingText; }
                set { greetingText = value; }
            }
            public int MaxRepeatRate
            {
                get { return maxRepeatRate; }
                set { maxRepeatRate = value; }
            }
            public int ItemsInMRUList
            {
                get { return itemsInMRU; }
                set { itemsInMRU = value; }
            }
            public bool SettingsChanged
            {
                get { return settingsChanged; }
                set { settingsChanged = value; }
            }
            public string AppVersion
            {
                get { return appVersion; }
                set { appVersion = value; }
            }
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

        private delegate void SetprogressBarHandle(int vaule); 
        //private void SetprogressBar(int vaule)
        //{
        //    if (this.Dispatcher.Thread != System.Threading.Thread.CurrentThread)
        //    {
        //        this.Dispatcher.Invoke(new SetprogressBarHandle(this.SetprogressBar), vaule);
        //    }
        //    else
        //    {
        //        MyProgressBar.Value = vaule;
        //        if (MyProgressBar.Value >= 10)
        //        {
        //            MyProgressBar.Visibility = Visibility.Hidden;
        //            mThread.Abort();
        //        }
        //    }
        //}

        //private void ThreadProcess(object obj)
        //{
        //    int i = 0;
        //    while (true)
        //    {
        //        i+=2;
        //        if (i > 10)
        //        {
        //            i = 0;
        //        }
        //        SetprogressBar(i);
        //        Thread.Sleep(1000);
        //    }
        //}


        public class tmpclass
        {
            //[TypeConverter(typeof(ExpandableObjectConverter))]
            //public List<string> StringList { get; set; }
            //public List<int> IntList { get; set; }
            //public List<object> ObjectList { get; set; }
            //public List<tmpclass> TMPlst { get; set; }

            public string Name { get; set; }
            public string test { get; set; }
            public string test1 { get; set; }
            public string test2 { get; set; }
        }

        public tmpclass tmpClassInstace;
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

            tmpClassInstace = new tmpclass();

            tmpClassInstace.Name = "aaa";
            tmpClassInstace.test = "test";
            tmpClassInstace.test1 = "test1";
            tmpClassInstace.test2 = "test2";

            myGrid.Instance = tmpClassInstace;


        }

        private void Btn_BladeDoubleClick(object sender, RoutedEventArgs e)
        { }
        private void Btn_BladeClick(object sender, RoutedEventArgs e)
        { }
    }

    public sealed class MachineCapability
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }

    //public sealed class CapabilityRepository
    //{
    //    private static IEnumerable<MachineCapability> s_Capability;

    //    public IEnumerable<MachineCapability> GetCapability() =>
    //      s_Capability ?? (s_Capability = new List<MachineCapability>
    //      {
    //          new MachineCapability { Name="ABS", Description = "Test", Value= "test" },
    //          new MachineCapability { Name="BHS", Description = "Test", Value= "test" },
    //          new MachineCapability { Name="LEOMS", Description = "Test", Value= "test" },
    //          new MachineCapability { Name="LEO_", Description = "Test", Value= "test" }
    //      });
    //}
}
