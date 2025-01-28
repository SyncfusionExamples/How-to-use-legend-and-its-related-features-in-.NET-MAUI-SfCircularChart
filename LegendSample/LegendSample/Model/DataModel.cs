using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendSample.Model
{
    public class DataModel
    {
        public string Country { get; set; }
        public double Value { get; set; }

        public DataModel(string country, double value)
        {
            Country = country;
            Value = value / 1000; //Thousand to million conversion
        }
    }
}
