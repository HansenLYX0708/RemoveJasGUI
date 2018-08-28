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

namespace JadeGUI
{
    /// <summary>
    /// TestGridControl.xaml 的交互逻辑
    /// </summary>
    public partial class TestGridControl : UserControl
    {
        public TestGridControl()
        {
            InitializeComponent();
        }

        private void Btn_BladeDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TestInstance testInstance = new TestInstance();
            testInstance.ShowDialog();
        }

        private void Btn_BladeClick(object sender, RoutedEventArgs e)
        {
            //testInstance.Hide();
        }

        
    }
}
