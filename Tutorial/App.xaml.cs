using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

using Tutorial.WPF_Application;        // Window의 namespace
using Tutorial.Basic_controls;
using Tutorial.Control_concepts;
using Tutorial.Panels;
using Tutorial.User_Controls;
using Tutorial.DataBinding;         
using Tutorial.Commands;
using Tutorial.Dialogs;
using Tutorial.Common_interface_controls;
using Tutorial.Rich_text_controls;

namespace Tutorial;                     // App의 namespace

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        MessageBox.Show("Application_DispatcherUnhandledException just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Error);
        e.Handled = true;
    }

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
        //InputDialogAppSample wnd = new InputDialogAppSample();  


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



        //*****************************************
        // NameSpace : Tutorial.User_Controls

        //LimitedInputSample wnd= new LimitedInputSample();   



        //*****************************************
        // NameSpace : Tutorial.Panels

        //Canvas wnd = new Canvas();
        //CanvasZIndex wnd = new CanvasZIndex();  
        //WrapPanel wnd= new WrapPanel(); 
        //StackPanel wnd = new StackPanel();
        //DockPanel wnd= new DockPanel();
        //Grid wnd = new Grid();
        //TabularGrid wnd = new TabularGrid();
        //GridUnits wnd = new GridUnits();
        //GridColRowSpan wnd = new GridColRowSpan();
        //GridColRowSpanAdvanced wnd = new GridColRowSpanAdvanced();
        //GridSplitterSample wnd = new GridSplitterSample();
        //GridContactForm wnd = new GridContactForm();
        //GridContactFormTake2 wnd= new GridContactFormTake2();


        //*****************************************
        // NameSpace : Tutorial.Control_concepts

        //ToolTipsSimpleSample wnd = new ToolTipsSimpleSample();
        //ToolTipsAdvancedSample wnd = new ToolTipsAdvancedSample();
        //TextFormattingModeSample wnd = new TextFormattingModeSample();
        //TextRenderingModeSample wnd = new TextRenderingModeSample();    
        //TabOrderSample wnd = new TabOrderSample();
        //AccessKeysLabelTargetSample wnd = new AccessKeysLabelTargetSample();


        //*****************************************
        // NameSpace : Tutorial.Basic_controls

        //TextBlockSample wnd = new TextBlockSample();    
        //TextBlockInlineSample wnd = new TextBlockInlineSample();
        //TextBlockHyperlinkSample wnd = new TextBlockHyperlinkSample();
        //TextBlockSpanSample wnd = new TextBlockSpanSample();
        //LabelControlSample wnd = new LabelControlSample();
        //LabelControlAdvancedSample wnd = new LabelControlAdvancedSample();
        //TextBoxSample wnd = new TextBoxSample();
        //TextBoxSelectionSample wnd= new TextBoxSelectionSample(); 
        //ButtonSample wnd = new ButtonSample();
        //CheckBoxSample wnd = new CheckBoxSample();
        //CheckBoxThreeStateSample wnd = new CheckBoxThreeStateSample();
        //RadioButtonSample wnd = new RadioButtonSample();
        //PasswordBoxSample wnd = new PasswordBoxSample();


        //*****************************************
        // NameSpace : Tutorial.WPF_Application

        //ResourceSample wnd = new ResourceSample();
        //ExtendedResourceSample wnd = new ExtendedResourceSample();
        //ResourcesFromCodeBehindSample wnd = new ResourcesFromCodeBehindSample();
        //ExceptionHandlingSample wnd = new ExceptionHandlingSample();
        //ApplicationCultureSwitchSample wnd = new ApplicationCultureSwitchSample();



        //*****************************************
        // NameSpace : Tutorial.Common_interface_controls

        //MenuSample wnd= new MenuSample();
        //MenuIconCheckableSample wnd= new MenuIconCheckableSample();
        //MenuWithCommandsSample wnd = new MenuWithCommandsSample();
        //ContextMenuSample wnd = new ContextMenuSample();
        //ContextMenuWithCommandsSample wnd = new ContextMenuWithCommandsSample();
        //ContextMenuManuallyInvokedSample wnd= new ContextMenuManuallyInvokedSample();



        //*****************************************
        // NameSpace : Tutorial.Common_interface_controls

        //FlowDocumentScrollViewerSample wnd = new FlowDocumentScrollViewerSample();
        //FlowDocumentScrollViewerZoomSample wnd = new FlowDocumentScrollViewerZoomSample();
        //FlowDocumentTextAlignmentSample wnd = new FlowDocumentTextAlignmentSample();
        //ExtendedFlowDocumentSample wnd = new ExtendedFlowDocumentSample();

        //여기서 문제 있음
        //BlockUIContainerSample wnd = new BlockUIContainerSample();
        RichTextBoxSample wnd = new RichTextBoxSample();


        wnd.Show();
    }

}

