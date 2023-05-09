using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {

            string[] DayOfWeekJp = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日"};

            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product Karinto = new Product(123, "かりんとう", 180);
            //Product Daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("税込価格" + Karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込価格" + Daifuku.GetPriceIncludingTax());
            #endregion

            #region Date
            //DateTime date = new DateTime(2023, 5, 8);
            //DateTime date = DateTime.Today;

            //10日後を求める
            //DateTime daysAfter10 = date.AddDays(10);
            //10日前を求める
            //DateTime daysBefore10 = date.AddDays(-10);

            //Console.WriteLine("今日の日付:" + date);
            //Console.WriteLine("10日後:" + daysAfter10.ToString(@"yyyy\/MM\/dd"));
            //Console.WriteLine("10日前:" + daysBefore10.ToString(@"yyyy\/MM\/dd"));
            #endregion

            Console.WriteLine("誕生日を入力");
            Console.Write("西暦:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            DateTime happy = new DateTime(year, month, day);
            DateTime toDate = DateTime.Today;

            TimeSpan interval = toDate - happy;

            Console.WriteLine("あなたは生まれてから今日まで {0}", interval.TotalDays + "日目です。");

            Console.WriteLine(DayOfWeekJp[(int)happy.DayOfWeek]);
        }
    }
}
