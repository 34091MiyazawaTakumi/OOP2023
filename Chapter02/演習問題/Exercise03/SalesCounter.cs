﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);

        }

        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerProductCategorySales() {
            var dict = new Dictionary<string, int>();

            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;  //店名が既に存在する（加算）
                else
                    dict[sale.ProductCategory] = sale.Amount;  //店名が存在しない（新規作成）
            }
            return dict;
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private IEnumerable<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();  //売り上げデータを格納する
            var lines = File.ReadAllLines(filePath);  //ファイルからすべてのデータを読み込む
            
            foreach (var line in lines) {  //すべての行から一行ずつ取り出す
                var items = line.Split(',');
                var sale = new Sale {  //Saleインスタンスを生成
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
