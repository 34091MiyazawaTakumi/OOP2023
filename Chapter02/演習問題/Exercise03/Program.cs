using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            
            var sales = new SalesCounter(@"data\Sales.csv");
            var amountPerShop = sales.GetPerShopSales();
            foreach (var obj in amountPerShop) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
