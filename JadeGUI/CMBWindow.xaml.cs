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
using System.Windows.Shapes;

namespace JadeGUI
{
    /// <summary>
    /// CMBWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CMBWindow : Window
    {
        #region Filed
        /// <summary>
        /// 显示的内容
        /// </summary>
        public string MessageBoxText { get; set; }
        /// <summary>
        /// 显示的图片
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// 控制显示 OK 按钮
        /// </summary>
        public Visibility OkButtonVisibility { get; set; }
        /// <summary>
        /// 控制显示 Cacncel 按钮
        /// </summary>
        public Visibility CancelButtonVisibility { get; set; }
        /// <summary>
        /// 控制显示 Yes 按钮
        /// </summary>
        public Visibility YesButtonVisibility { get; set; }
        /// <summary>
        /// 控制显示 No 按钮
        /// </summary>
        public Visibility NoButtonVisibility { get; set; }
        /// <summary>
        /// 消息框的返回值
        /// </summary>
        public CustomMessageBoxResult Result { get; set; }

        #endregion

        public CMBWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            OkButtonVisibility = Visibility.Collapsed;
            CancelButtonVisibility = Visibility.Collapsed;
            YesButtonVisibility = Visibility.Collapsed;
            NoButtonVisibility = Visibility.Collapsed;

            Result = CustomMessageBoxResult.None;
        }

        #region Method
        private void DXRibbonWindow_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnClose_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Result = CustomMessageBoxResult.OK;
            this.Close();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Result = CustomMessageBoxResult.Yes;
            this.Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Result = CustomMessageBoxResult.No;
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Result = CustomMessageBoxResult.Cancel;
            this.Close();
        }
        #endregion

    }
}
