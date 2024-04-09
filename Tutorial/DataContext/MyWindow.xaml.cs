﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tutorial.DataContext;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MyWindow : Window
{
    public MyWindow()
    {
        InitializeComponent();

        this.DataContext = this;
    }
}