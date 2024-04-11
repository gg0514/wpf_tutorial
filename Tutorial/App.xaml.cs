using System.Configuration;
using System.Data;
using System.Windows;

using Tutorial.DataBinding;         // Window의 namespace
using Tutorial.Commands;
using Tutorial.Dialogs;

namespace Tutorial;                 // App의 namespace

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    private void Application_Startup(object sender, StartupEventArgs e)
    {

        //*****************************************
        // NameSpace : Tutorial.Dialogs

        //MessageBoxSample wnd = new MessageBoxSample();  
        //OpenFileDialogSample wnd = new OpenFileDialogSample();
        //OpenFileDialogMultipleFilesSample wnd = new OpenFileDialogMultipleFilesSample();
        //SaveFileDialogSample wnd = new SaveFileDialogSample();

        // 다이얼로그를 여기서 호출하니 문제있음!!
        //InputDialogSample wnd = new InputDialogSample("Please enter your name", "park");

        InputDialogAppSample wnd = new InputDialogAppSample();  


        //*****************************************
        // NameSpace : Tutorial.Commands

        //UsingCommandsSample wnd = new UsingCommandsSample();    
        //CommandCanExecuteSample wnd = new CommandCanExecuteSample();
        //CommandsWithCommandTargetSample wnd = new CommandsWithCommandTargetSample();
        //CustomCommandSample wnd = new CustomCommandSample();



        //*****************************************
        // NameSpace : Tutorial.DataBinding 

        //HelloBoundWorldSample wnd = new HelloBoundWorldSample();
        //DataContextSample wnd = new DataContextSample();
        //CodeBehindBindingsSample wnd = new CodeBehindBindingsSample();
        //ChangeNotificationSample wnd = new ChangeNotificationSample();
        //ConverterSample wnd = new ConverterSample();
        //StringFormatSample wnd = new StringFormatSample();
        //DataBindingDebuggingSample wnd = new DataBindingDebuggingSample();


        wnd.Show();
    }

}

