using System;
using System.Windows;
using Tutorial.Dialogs;

namespace Tutorial.Dialogs
{
    public partial class InputDialogAppSample : Window
    {
        public InputDialogAppSample()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample("Please enter your name:", "John Doe");
            if (inputDialog.ShowDialog() == true)
                lblName.Text = inputDialog.Answer;
        }
    }
}