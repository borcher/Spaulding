using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2.Interfaces;

namespace ClassLibrary2.Classes
{
    public class SalesData: ISalesData
    {
        public List<SalesClass> Sales { get; set; }
        public List<TotalPerState> StateSales { get; set; }
        public double TotalSales { get; set; }
    }
}
