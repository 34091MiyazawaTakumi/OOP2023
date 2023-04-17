using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            string[] moneyString = {"一万円札", "五千円札" , "二千円札", "千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉"};
            int[] moneyInteger = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };

            Console.Write("金額:");
            int amount = int.Parse(Console.ReadLine());
            Console.Write("支払い:");
            int pay = int.Parse(Console.ReadLine());
            int change = pay - amount; 
            Console.WriteLine("お釣り:{0}円", change);

            //金種の枚数出力
            for (int i = 0; i < moneyString.Length; i++)
            {
                //Console.WriteLine(moneyString[i] + ":{0}枚", change / moneyInteger[i]);
                Console.Write(moneyString[i] + ":");
                astOut(change / moneyInteger[i]);
                change %= moneyInteger[i];
            }

            /*int mai = change / 10000;
            Console.Write("一万円札:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 / 5000;
            Console.Write("五千円札:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 / 2000;
            Console.Write("二千円札:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 / 1000;
            Console.Write("千円札:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 % 1000 / 500;
            Console.Write("五百円玉:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 % 1000 % 500 / 100;
            Console.Write("百円玉:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 % 1000 % 500 % 100 / 50;
            Console.Write("五十円玉:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 % 1000 % 500 % 100 % 50 / 10;
            Console.Write("十円玉:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 % 1000 % 500 % 100 % 50 % 10 / 5;
            Console.Write("五円玉:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");
            mai = change % 10000 % 5000 % 1000 % 500 % 100 % 50 % 10 % 5 / 1;
            Console.Write("一円玉:");
            for (int i = 0; i < mai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("枚");*/
        }

        //指定した個数の"*"を出力
        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();  //改行
        }
    }
}
