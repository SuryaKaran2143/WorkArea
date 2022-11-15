using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorChartMAUI
{
    public class Production
    {
        public int ID { get; set; } 
        public double Coal { get; set; }    

        public double HorizontalErrorValue { get; set; }
        public double VerticalErrorValue { get; set; }   
    }
}
