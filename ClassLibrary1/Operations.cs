using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operations
    {
        public List<string> GetYears()
        {
            List<String> Years = new List<string>();
            Years.Add("Select Item");
            using (SpauldingEntities db = new SpauldingEntities())
            {
                db.Orders.Select(f => f.OrderDate.Year).Distinct().OrderBy(f=>f).ToList().ForEach(d => Years.Add(d.ToString()));
                return Years;
            }
        }
        public List<SalesClass> YearSales(string Year)
        {
            List<SalesClass> salesResult = new List<SalesClass>();
            var dateStart = DateTime.Parse(Year + "-01-01");
            var dateEnd = DateTime.Parse(Year + "-12-31");
            using (SpauldingEntities db = new SpauldingEntities())
            {
                 (from p in db.Products
                            join o in db.Orders on p.OrderId equals o.OrderId
                            where (o.OrderDate >= dateStart && o.OrderDate <= dateEnd)
                            select new 
                          {
                              p.OrderId, p.ProductName,p.Sales,o.State
                          }).ToList().ForEach(r=>salesResult.Add(new SalesClass()
                          {
                              OrderId = r.OrderId,
                              ProductName = r.ProductName,
                              Sales = r.Sales,
                              State = r.State
                          }));
            }
            return salesResult;
        }

        public Double TotalSales(string Year)
        {
            var sales=YearSales(Year);
            using (SpauldingEntities db = new SpauldingEntities())
            {
                var Excludes = db.OrdersReturns.Select(c=>c.OrderId).ToList();
                return sales.Where(s => !Excludes.Contains(s.OrderId)).Sum(s => s.Sales);
            }
        }

        public List<TotalPerState> TotalSalesPerState(string Year)
        {
            var sales = YearSales(Year);
            List<TotalPerState> totals = new List<TotalPerState>();
            using (SpauldingEntities db = new SpauldingEntities())
            {
                var Excludes = db.OrdersReturns.Select(c => c.OrderId).ToList();

                sales
                    .Where(d => !Excludes.Contains(d.OrderId))
                    .GroupBy(s => s.State)
                    .Select(g => (g.Key, SUM: g.Sum(s => s.Sales)))
                    .ToList().ForEach(r=>totals.Add(new TotalPerState() 
                    {State=r.Key,Sales=r.SUM 
                    }));
            }
            return totals;
        }
    } 
}
