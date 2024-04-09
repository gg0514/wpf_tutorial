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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;



namespace Tutorial.ChangeNotification;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MyWindow : Window
{

    public class User : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }



    private ObservableCollection<User> users = new ObservableCollection<User>();

    public MyWindow()
    {
        InitializeComponent();

        users.Add(new User() { Name = "John Doe" });
        users.Add(new User() { Name = "Jane Doe" });

        lbUsers.ItemsSource = users;
    }

    private void btnAddUser_Click(object sender, RoutedEventArgs e)
    {
        users.Add(new User() { Name = "New user" });
    }

    private void btnChangeUser_Click(object sender, RoutedEventArgs e)
    {
        if (lbUsers.SelectedItem != null)
            (lbUsers.SelectedItem as User).Name = "Random Name";
    }

    private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
    {
        if (lbUsers.SelectedItem != null)
            users.Remove(lbUsers.SelectedItem as User);
    }
}