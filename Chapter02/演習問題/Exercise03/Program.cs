﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**売上集計**");
            Console.WriteLine("1.店舗別売り上げ");
            Console.WriteLine("2.商品カテゴリ別売り上げ");
            Console.Write(">");

            int num = int.Parse(Console.ReadLine());

            var sales = new SalesCounter(@"data\Sales.csv");

            IDictionary<string, int> amountPerStore;
            if (num == 1) {
                amountPerStore = sales.GetPerShopSales();
            }else {
                amountPerStore = sales.GetPerProductCategorySales();
            }
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
