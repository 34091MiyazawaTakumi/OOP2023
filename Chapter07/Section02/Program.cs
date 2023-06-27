using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("県庁所在地の登録");

            var dict = new Dictionary<string, List<CityInfo>>();

            Console.Write("県名:");
            var ken = Console.ReadLine();

            while (ken != "999") {
                var cityinfo = new CityInfo();
                Console.Write("市町村:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());
                //既に県名が登録済みか？
                if (dict.ContainsKey(ken)) {
                    //List<CityInfo>が存在するためADDで市町村データを追加
                    dict[ken].Add(cityinfo);
                }
                else {
                    //List<CityInfo>が存在しないため、Listを作成（new）して市町村データを登録
                    dict[ken] = new List<CityInfo> { cityinfo };
                }
                Console.Write("県名:");
                ken = Console.ReadLine();
            }

            Console.WriteLine("1:一覧表示, 2:県名指定");
            var judge = Console.ReadLine();

            if (judge == "1") {
                foreach (var item in dict) {
                    foreach (var items in item.Value.OrderByDescending(p => p.Population)) {
                        Console.WriteLine("{0}【{1}({2})】)", item.Key, items.City, items.Population);
                    }
                }
            }
            else if (judge == "2") {
                Console.Write("県名を入力:");
                var kenName = Console.ReadLine();
                foreach (var item in dict[kenName]) {
                    Console.WriteLine("【{0}(人口:{1}人)】", item.City, item.Population);
                }
            }
        }
    }
    class CityInfo {
        public string City { get; set; }  //都市
        public int Population { get; set; }  //人口
    }
}
