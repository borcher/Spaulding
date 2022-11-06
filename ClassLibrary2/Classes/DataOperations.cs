using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace ClassLibrary2.Classes
{
    public class DataOperations
    {
        public SalesData _sales { get; set; }
        private ClassLibrary1.Operations operations = new ClassLibrary1.Operations();
        CsvFileDescription inputFileDescription = new CsvFileDescription
        {
            SeparatorChar = ',',
            FirstLineHasColumnNames = true
        };

        public DataOperations()
        {
            _sales = new SalesData();
        }
        public List<string> GetYear()
        {
            return operations.GetYears();
        }
        public void GetSales(String year)
        {
            _sales.Sales = operations.YearSales(year);
            _sales.StateSales = operations.TotalSalesPerState(year);
            _sales.TotalSales = operations.TotalSales(year);
        }
        
        public void GetIncrementData(double percentage)
        {
            double realpercentage = percentage / 100;
            if (_sales.Sales != null || _sales.StateSales!=null)
            {
                foreach(var it in _sales.Sales)
                {
                    it.IncrementalSales = it.Sales + (it.Sales * realpercentage);
                }
                foreach (var it in _sales.StateSales)
                {
                    it.IncrementalSales = it.Sales + (it.Sales * realpercentage);
                }
            }
        }

        public void DownloadToCSV(string path)
        {
            List<ExportToCSV> Export = new List<ExportToCSV>();
            CsvContext cc = new CsvContext();
            if (_sales.StateSales != null)
            {
                foreach (var item in _sales.StateSales)
                {
                    Export.Add(new ExportToCSV()
                    {
                        State = item.State,
                        IncrementalSales = item.IncrementalSales,
                        Sales = item.Sales
                    });
                }
                cc.Write(Export, path + "\\Export.csv", inputFileDescription);
            }
        }
    
    }
}
