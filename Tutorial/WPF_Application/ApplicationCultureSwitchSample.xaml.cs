﻿using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Tutorial.WPF_Application
{
    public partial class ApplicationCultureSwitchSample : Window
    {
        public ApplicationCultureSwitchSample()
        {
            InitializeComponent();
        }

        private void CultureInfoSwitchButton_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button).Tag.ToString());
            lblNumber.Content = (123456789.42d).ToString("N2");
            lblDate.Content = DateTime.Now.ToString();
        }
    }
}