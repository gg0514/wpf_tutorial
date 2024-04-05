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

namespace Tutorial.Event;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MyWindow : Window
{
    public MyWindow()
    {
        InitializeComponent();

        pnlMainGrid.MouseUp += new MouseButtonEventHandler(pnlMainGrid_MouseUp);
        pnlMainGrid.MouseDown += new MouseButtonEventHandler(pnlMainGrid_MouseDown);
    }

    private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
    }    

    private void pnlMainGrid_MouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("You mouse downed at " + e.GetPosition(this).ToString());
    }    
}