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
using Models;
using Microsoft.Extensions.DependencyInjection;

namespace RemoveJasGUI
{
    /// <summary>
    /// TeachTabControl.xaml 的交互逻辑
    /// </summary>
    public partial class TeachGridControl : UserControl
    {
        public TeachGridControl()
        {
            InitializeComponent();
        }

        public Blade Blade1
        {
            get
            {
                return (App.Current as App).Container.GetService<Blade>();
            }
        }


        /**********************************************************************/
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
