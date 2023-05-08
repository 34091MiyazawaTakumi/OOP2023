﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product Karinto = new Product(123, "かりんとう", 180);
            //Product Daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("税込価格" + Karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込価格" + Daifuku.GetPriceIncludingTax());
            #endregion

            //DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);

            Console.WriteLine("今日の日付:" + date);
            Console.WriteLine("10日後:" + daysAfter10.ToString(@"yyyy\/MM\/dd"));
            Console.WriteLine("10日前:" + daysBefore10.ToString(@"yyyy\/MM\/dd"));
        }
    }
}
