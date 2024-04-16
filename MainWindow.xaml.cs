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
using System.Windows.Threading;

namespace wpf_vs_docking;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : RibbonWindow
{
    DispatcherTimer timer = new DispatcherTimer
    {
        Interval = new TimeSpan(0, 0, 0, 0, 500),
        IsEnabled = false
    };
    public MainWindow()
    {
        InitializeComponent();
        this.Loaded+=(obj, args) => this.SizeChanged += Window_SizeChanged;
    }

    private void OnClear(object sender, EventArgs args)
    {
        Log.Text = "";
    }

    private void Window_SizeChanged (object sender, SizeChangedEventArgs e)
    {
        var ah = ActualHeight;
        var aw = ActualWidth;
        var h = Height;
        var w = Width;
        // Console.WriteLine ("ActualHeight(updated height value): {0}, ActualWidth(updated width value): {1}, Height(before size change): {2}, Width(before size change): {3}", ah, aw, h, w);
        double controlsize = ((w / 12) / 3 * 2) / 5 * 0.7;
        System.Windows.Application.Current.Resources.Remove("ControlFontSize");
        System.Windows.Application.Current.Resources.Add("ControlFontSize", controlsize);
    }
}