using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };

            Console.WriteLine(numbers.Average());

            var books = Books.GetBooks();

            //Console.WriteLine(books.Average(n => n.Price));
            //Console.WriteLine(books.Average(n => n.Pages));
            //Console.WriteLine(books.Max(n => n.Price));

            var booksObj = books.Where(n => n.Title.Contains("物語")).Average(n => n.Pages);
            Console.WriteLine("平均:{0}円", booksObj);

            var LongTitleBooks = books.OrderByDescending(n => n.Title.Length);
            foreach (var book in LongTitleBooks) {
                Console.WriteLine(book.Title);
            }

        }
    }
}
