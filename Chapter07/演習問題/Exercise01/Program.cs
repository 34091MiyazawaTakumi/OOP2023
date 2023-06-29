using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach (var item in text.ToUpper().Where(c => c != ' ')) {
                if (dict.ContainsKey(item)) {
                    dict[item] += 1;
                }
                else {
                    dict[item] = 1;
                }
            }
            foreach (var item in dict.OrderBy(c => c.Key)) {
                Console.WriteLine("'{0}':{1}", item.Key, item.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var newDict = new SortedDictionary<Char, int>();
            foreach (var item in text.ToUpper().Where(c => c != ' ')) {
                if (newDict.ContainsKey(item)) {
                    newDict[item] += 1;
                }
                else {
                    newDict[item] = 1;
                }
            }
            foreach (var item in newDict) {
                Console.WriteLine("'{0}':{1}", item.Key, item.Value);
            }
        }
    }
}
