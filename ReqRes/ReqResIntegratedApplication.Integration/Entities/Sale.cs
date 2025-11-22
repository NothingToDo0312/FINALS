using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqResIntegratedApplication.Integration.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public decimal SaleAmount { get; set; }
        public string SaleDate { get; set; }

        public static class SaleMockData
        {
            public static List<Sale> Sales = new List<Sale>
            {
                new Sale { Id = 1, ProductName = "Cerulean", QuantitySold = 15, SaleAmount = 4500.00M, SaleDate = "2025-11-01" },
                new Sale { Id = 2, ProductName = "Fuchsia Rose", QuantitySold = 8, SaleAmount = 2400.00M, SaleDate = "2025-11-02" },
                new Sale { Id = 3, ProductName = "True Red", QuantitySold = 20, SaleAmount = 6000.00M, SaleDate = "2025-11-03" },
                new Sale { Id = 4, ProductName = "Aqua Sky", QuantitySold = 10, SaleAmount = 3000.00M, SaleDate = "2025-11-04" }
            };
        }
    }
}
