﻿using System.Text;
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
}