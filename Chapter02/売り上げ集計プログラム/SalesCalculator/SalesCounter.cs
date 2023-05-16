﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    public class SalesCounter {

        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }

        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;  //店名が既に存在する（加算）
                else
                    dict[sale.ShopName] = sale.Amount;  //店名が存在しない（新規作成）
            }
            return dict;
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        public static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();  //売り上げデータを格納する
            string[] lines = File.ReadAllLines(filePath);  //ファイルからすべてのデータを読み込む

            foreach (string line in lines) {  //すべての行から一行ずつ取り出す
                string[] items = line.Split(',');
                Sale sale = new Sale {  //Saleインスタンスを生成
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);  //Saleインスタンスをコレクションに追加
            }
            return sales;
        }
    }
}
