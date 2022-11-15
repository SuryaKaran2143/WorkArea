using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorChartMAUI
{
    
    public class ViewModel
    {
        public List<Production> EnergyProductions { get; set; }
        public ViewModel()
        {
            EnergyProductions = new List<Production>()
            {
                new Production { ID = 1 , Coal = 100 ,HorizontalErrorValue=0.2,VerticalErrorValue=20},
                new Production { ID = 2 , Coal = 200,HorizontalErrorValue=0.4,VerticalErrorValue=30},
                new Production { ID = 3 , Coal = 300,HorizontalErrorValue=0.6,VerticalErrorValue=40 },
                new Production { ID = 4 , Coal = 400 ,HorizontalErrorValue=0.7,VerticalErrorValue=50},
                new Production { ID = 5 , Coal = 500,HorizontalErrorValue=0.8,VerticalErrorValue=60 }
            };
        }
    }
}

