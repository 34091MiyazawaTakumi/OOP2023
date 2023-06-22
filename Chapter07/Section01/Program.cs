﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var flowerDict = new Dictionary<string, int>() {
                ["sunflower"] = 400,
                ["pansy"] = 400,
                ["tulip"] = 400,
                ["rose"] = 400,
                ["dahlia"] = 400,
            };

            //morning glory(あさがお)【250円】を追加
            flowerDict["morning glory"] = 250;

            Console.WriteLine(" ひまわりの価格は{0}円です。", flowerDict["sunflower"]);
            Console.WriteLine(" チューリップの価格は{0}円です。", flowerDict["tulip"]);
            Console.WriteLine(" あさがおの価格は{0}円です。", flowerDict["morning glory"]);

        }
    }
}
