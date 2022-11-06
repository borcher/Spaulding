using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2.Interfaces
{
    public interface ISalesData
    {
         List<SalesClass> Sales { get; set; }
         List<TotalPerState> StateSales { get; set; }
         double TotalSales { get; set; }
    }
}
