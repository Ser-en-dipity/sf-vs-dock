using System.Windows;
using System.Windows.Controls;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Threading;
using System.Windows.Input;
using Syncfusion.UI.Xaml.Charts;
using wpf_vs_docking;

namespace iCNC.Servo
{
    public partial class WPFControlsDict : ResourceDictionary
    { 
        public void onClickParameters(object sender, MouseButtonEventArgs e)
        {
            var MainWindow = Application.Current.MainWindow;
            DockingManager SyncDockingManager = (DockingManager)MainWindow.FindName("DockingManager");
        
            SyncDockingManager.UseDocumentContainer = true;

            SyncDockingManager.ContainerMode = DocumentContainerMode.TDI;

            SfChart chart = new SfChart();
            CategoryAxis primaryAxis = new CategoryAxis();
            chart.PrimaryAxis = primaryAxis; 
            NumericalAxis secondaryAxis = new NumericalAxis();
            chart.SecondaryAxis = secondaryAxis;

            ContentControl chartControl = new ContentControl();
            chartControl.Content = chart;

            DockingManager.SetHeader(chartControl, "chart");

            DockingManager.SetState(chartControl, DockState.Document);

            SyncDockingManager.Children.Add(chartControl);

            

            
        }
       
    }

    
}