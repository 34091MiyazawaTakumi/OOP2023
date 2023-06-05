using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数:{0}", spaces);
        }

        private static void Exercise3_2(string text) {
            var change = text.Replace("big", "small");
            Console.WriteLine(change);
        }

        private static void Exercise3_3(string text) {
            String[] words = text.Split(' ');
            var count = words.Length;
            Console.WriteLine("単語数:" + count);

            //int count = text.Split(' ').length;
            //Console.WriteLine("単語数:{0}", count);
        }

        private static void Exercise3_4(string text) {
            var word = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var words in word) {
                Console.WriteLine(words);
            }
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ').ToArray();

            var sb = new StringBuilder(words[0]);
            foreach (var word in words.Skip(1)) {
                sb.Append(' ' + word);
            }
            var str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}
