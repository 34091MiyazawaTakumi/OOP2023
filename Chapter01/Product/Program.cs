using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {
            //インスタンスの生成
            Product Karinto = new Product(123, "かりんとう", 180);
            Product Daifuku = new Product(235, "大福もち", 160);

            Console.WriteLine("税込価格" + Karinto.GetPriceIncludingTax());
            Console.WriteLine("税込価格" + Daifuku.GetPriceIncludingTax());

        }
    }
}
