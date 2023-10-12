using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            foreach (var book in Library.Books.Where(b => b.Price == Library.Books.Max(p => p.Price))) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            foreach (var books in groups) {
                var book = books.Count();
                Console.WriteLine("{0}:{1}", books.Key, book);
            }
                
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear)
                                        .ThenByDescending(b => b.Price)
                                        .Join(Library.Categories,
                                            book => book.CategoryId, category => category.Id,
                                            (book, category) => new {
                                                Title = book.Title,
                                                Category = category.Name,
                                                Price = book.Price,
                                                PublishedYear = book.PublishedYear,
                                            }
                                        );

            foreach (var book in books) {
                Console.WriteLine("{0}年 {1}円 {2}({3})",
                                book.PublishedYear, book.Price, book.Title, book.Category);
            }
        }

        private static void Exercise1_5() {
            //foreach (var book in Library.Books.Where(b => b.Publis)) {
            //    Console.WriteLine("{0}", book);
            //}
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
