using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average( x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum( x => x.Pages) + "ページ");
            Console.WriteLine("最も価格が高い本は" + books.Max( x => x.Price) + "円");
            Console.WriteLine("最も価格が安い本は" + books.Min(x => x.Price) + "円");
            //500円以上の本は何冊
            Console.WriteLine("500円以上の本は" + books.Where(x => 500 <= x.Price).Count() + "冊");

            //本のタイトルに「物語」が含まれている冊数
            Console.WriteLine("「物語」が含まれている冊数は" + books.Count(x => x.Title.Contains("物語")) + "です。");

            //本のタイトルに「物語」が含まれている本の一覧
            var bookData = books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach (var book in bookData) {
                Console.WriteLine(book.Title);
            }

            //高額書籍ベスト3           
            var sortedBooks = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var sort in sortedBooks) {
                Console.WriteLine(sort.Price + "円" + " : " + sort.Title);
            }

            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
