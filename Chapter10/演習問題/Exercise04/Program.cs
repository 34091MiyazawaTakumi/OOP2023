using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");

            var newline = lines
                .Select(s => Regex.Replace(s, @"\b(V|v)ersion\s*=\s*""v4.0""", @"version=""v5.0"""));

            //書き込み
            File.WriteAllLines("sample.txt", newline);

            //foreach (var line in lines) {
            //    var matches = Regex.Matches(line, @"(V|v)ersion *= *""v4.0""");
            //    foreach (Match match in matches) {
            //        var replaced = Regex.Replace(line, match.Value, @"version=""v5.0""");
            //        //書き込み
            //        File.WriteAllLines("sample.txt", replaced);
            //    }
            //}

            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
