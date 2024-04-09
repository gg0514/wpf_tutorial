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

    private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
    {
        // Binding Explicit 샘플
        // TextBox의 TextProperty를 바인딩소스로 지정하고, 업데이트함
        BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
        binding.UpdateSource();
    }
}