﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            Stopwatch sw = new Stopwatch(); //タイマーインスタンス生成
            sw.Start(); //タイマースタート

#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
#elif StringArray
            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
#endif

#if NonArray
            var array = line.Split(';','=').ToArray();
            Console.WriteLine("作家　:" + array[1]);
            Console.WriteLine("代表作:" + array[3]);
            Console.WriteLine("誕生年:" + array[5]);
#elif StringArray
            for (int i = 0; i < lines.Length; i++) {
                var array = lines[i].Split(';', '=').ToArray();
                Console.WriteLine("作家　:" + array[1]);
                Console.WriteLine("代表作:" + array[3]);
                Console.WriteLine("誕生年:" + array[5]);
            }
#endif
            Console.WriteLine("実行時間 = {0}", sw.Elapsed.ToString(@"ss\.fffff")); //時間表示
        }
    }
}
