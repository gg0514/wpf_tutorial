﻿using System.Configuration;
using System.Data;
using System.Windows;

using Tutorial.DataBinding;         // Window의 namespace

namespace Tutorial;                 // App의 namespace

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        //*****************************************
        // NameSpace : Tutorial.DataBinding 

        //HelloBoundWorldSample wnd = new HelloBoundWorldSample();
        //DataContextSample wnd = new DataContextSample();
        //CodeBehindBindingsSample wnd = new CodeBehindBindingsSample();
        //ChangeNotificationSample wnd = new ChangeNotificationSample();
        //ConverterSample wnd = new ConverterSample();
        //StringFormatSample wnd = new StringFormatSample();
        DataBindingDebuggingSample wnd = new DataBindingDebuggingSample();

        wnd.Show();
    }

}

