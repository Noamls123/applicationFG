﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;

namespace app0
{
    /// <summary>
    /// Interaction logic for Graph_Ilustraion.xaml
    /// </summary>
    public partial class Graph_Ilustraion : UserControl
    {
        private ViewModel vm;

        public Graph_Ilustraion(ViewModel v)
        {
            vm = v;
            InitializeComponent();
            //LinearReg();
            DataContext = vm;
            //this.MyModel = new PlotModel { Title = "Example 1" };
            //this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }


        //public PlotModel MyModel { get; private set; }
    }
}