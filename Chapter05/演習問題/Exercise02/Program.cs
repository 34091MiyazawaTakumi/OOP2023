using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("数字列:");
            var num = Console.ReadLine();

            int ret;
            if (int.TryParse(num, out ret)) {
                Console.WriteLine("{0:#,#}", ret);
            }
            else {
                Console.WriteLine("数値文字列でありません");
            }
        }
    }
}
