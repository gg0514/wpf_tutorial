using System.Configuration;
using System.Data;
using System.Windows;
using Tutorial.Binding;         // MyWindow의 namespace



namespace Tutorial;           // App Class의 namespace

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        // Create the startup window
        MyWindow wnd = new MyWindow();
        wnd.Show();
    }

}

