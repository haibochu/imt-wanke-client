﻿using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace imt_wankeyun_client
{
    /// <summary>
    /// AboutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            try
            {
                tbx_version.Text = GetEdition();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public static string GetEdition()
        {
            return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
        }
        private void About1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
