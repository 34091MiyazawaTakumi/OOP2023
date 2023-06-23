using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("県庁所在地の登録");

            var kenDict = new Dictionary<string, CityInfo>();

            var cityinfo = new CityInfo();

            Console.Write("県名:");
            var ken = Console.ReadLine();
            while (ken != "999") {
                Console.Write("所在地:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());
                kenDict[ken] = new CityInfo { City = cityinfo.City, Population = cityinfo.Population };
                Console.Write("県名:");
                ken = Console.ReadLine();
                if (kenDict.ContainsKey(ken)) {
                    Console.WriteLine("上書きしますか？ yes[0]/no[1]");
                    var YN = Console.ReadLine();
                    if (YN == "0") {

                    }
                    else if (YN == "1") {
                        Console.Write("県名:");
                        ken = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("1:一覧表示, 2:県名指定");
            var judge = Console.ReadLine();
            if (judge == "1") {
                foreach (var kenChi in kenDict) {
                    Console.WriteLine("{0}【{1}({2})】)", kenChi.Key, kenChi.Value.City, kenChi.Value.Population);
                }
            }
            else if (judge == "2") {
                Console.Write("県名を入力:");
                var kenName = Console.ReadLine();
                Console.WriteLine("【{0}(人口:{1}人)】", kenDict[kenName].City, kenDict[kenName].Population);
            }
        }
    }

    class CityInfo {
        public string City { get; set; }  //都市
        public int Population { get; set; }  //人口
    };
}
