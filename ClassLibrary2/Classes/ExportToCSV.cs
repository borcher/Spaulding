using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace ClassLibrary2.Classes
{
    public class ExportToCSV
    {
        [CsvColumn(Name = "Sales", FieldIndex = 1)]
        public double Sales { get; set; }

        [CsvColumn(Name = "IncrementalSales", FieldIndex = 2)]
        public double IncrementalSales { get; set; }

        [CsvColumn(Name = "State", FieldIndex = 3)]
        public string State { get; set; }

        
    }
}
