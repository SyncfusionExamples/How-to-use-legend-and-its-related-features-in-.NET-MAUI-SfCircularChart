﻿using LegendSample.Model;
using Syncfusion.Maui.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Microsoft.Maui.Graphics.Color;

namespace LegendSample.ViewModel
{
    public class ViewModel
    {
        public ObservableCollection<DataModel> DataCollection { get; set; }
        public ObservableCollection<DataModel> Data { get; set; }

        public List<Brush> CustomBrushes { get; set; }
        public ViewModel()
        {
            DataCollection = new ObservableCollection<DataModel>
            {
               new DataModel("India", 22500),
               new DataModel("Thailand", 8500),
               new DataModel("Vietnam",7500 ),
               new DataModel("Pakistan", 3600),
               new DataModel("US", 2125),
               new DataModel("Others", 1398),
            };

            CustomBrushes = new List<Brush>();
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#1060DC")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#00B553")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#DA6902")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#C71969")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#8AC114")));
            CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#8419C7")));
            CustomBrushes.Add(new SolidColorBrush(Colors.Green));
            CustomBrushes.Add(new SolidColorBrush(Colors.Brown));
            CustomBrushes.Add(new SolidColorBrush(Colors.DeepPink));
            CustomBrushes.Add(new SolidColorBrush(Colors.DarkBlue));
            CustomBrushes.Add(new SolidColorBrush(Colors.Orange));

        Data = new ObservableCollection<DataModel>
            {
               new DataModel("India", 22500),
               new DataModel("Thailand", 8500),
               new DataModel("Vietnam",7500 ),
               new DataModel("Pakistan", 3600),
               new DataModel("US", 2125),
               new DataModel("Argentina", 400),
               new DataModel("Australia",275 ),
               new DataModel("Brazil",1100 ),
               new DataModel("Burma", 1850),
               new DataModel("Cambodia", 1800),
               new DataModel("China",1800 ),
               new DataModel("European Union", 400),
               new DataModel("Guyana", 440),
               new DataModel("Paraguay", 820),
               new DataModel("Turkey",240 ),
               new DataModel("Uruguay", 900),
               new DataModel("Others", 1398),
            };

        
        }
    }

    // Define a custom legend class that extends ChartLegend
    public class LegendExt : ChartLegend
    {
        // Override the GetMaximumSizeCoefficient method to customize the legend size
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.9;
        }
    }
}
