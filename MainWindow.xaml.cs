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
using System;
using Syncfusion.Windows.Tools.Controls;

namespace wpf_vs_docking;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : RibbonWindow
{
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void OnClear(object sender, EventArgs args)
    {
        Log.Text = "";
    }

    private void Window_font_Loaded(object sender, RoutedEventArgs e)  
    {  
        Window MainWindow = Application.Current.MainWindow;
        PresentationSource MainWindowPresentationSource = PresentationSource.FromVisual(MainWindow);
        Matrix m = MainWindowPresentationSource.CompositionTarget.TransformToDevice;
        var thisDpiWidthFactor = m.M11;
        var thisDpiHeightFactor = m.M22;
        double ScreenHeight = SystemParameters.PrimaryScreenHeight * thisDpiHeightFactor;
        double ScreenWidth = SystemParameters.PrimaryScreenWidth * thisDpiWidthFactor;
        Console.WriteLine("Screen Height: " + ScreenHeight);
        Console.WriteLine("Screen Width: " + ScreenWidth);
        double controlsize = ((SystemParameters.PrimaryScreenWidth / 12) / 3 * 2) / 5 * 0.7;  
        System.Windows.Application.Current.Resources.Remove("ControlFontSize");  
        System.Windows.Application.Current.Resources.Add("ControlFontSize", controlsize);  
    }
}