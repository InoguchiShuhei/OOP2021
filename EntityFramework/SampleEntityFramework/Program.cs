using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //章末以前
            #region
            //using (var db = new BooksDbContext())
            //{
            //    var count = db.Books.Count();
            //    Console.WriteLine(count);

            //    db.Database.Log = sql => { Debug.Write(sql); };
            //}

            //データの追加
            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();
            //Two            

            //using (var db = new BooksDbContext())
            //{
            //        var Authors = db.Authors
            //                          .Where(a => a.Books.Count() >= 2);
            //        foreach (var a in Authors)
            //        {
            //            Console.WriteLine($"{a.Name}{a.Gender}{a.Birthday}");
            //        }

            //OrderBy
            //var books = db.Books
            //                 .OrderBy(b => b.PublishedYear)
            //                 .ThenBy(b => b.Author.Name);
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.Title}/{book.PublishedYear}/{book.Author.Name}");
            //}

            //        //PublishedYear
            //        var groups = db.Books
            //                          .GroupBy(b => b.PublishedYear)
            //                          .Select(g => new { Year = g.Key, Count = g.Count() });
            //        foreach (var g in groups)
            //        {
            //            Console.WriteLine($"{g.Year}{g.Count}");
            //        }

            //        //Most
            //        var author = db.Authors
            //                       .Where(a => a.Books.Count() ==
            //                                   db.Authors.Max(x => x.Books.Count()))
            //                       .First();
            //        Console.WriteLine($"{author.Name}{author.Gender}{author.Birthday}");
            //}
            #endregion

            //Exercise13_1_1();
            Exercise13_1_2();
            Exercise13_1_3();
            Exercise13_1_4();
            Exercise13_1_5();
        }

        private static void Exercise13_1_1()
        {
            //Authors
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author2);

                var author3 = new Author
                {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                };
                db.Authors.Add(author3);

                var author4 = new Author
                {
                    Birthday = new DateTime(1909, 6, 19),
                    Gender = "M",
                    Name = "太宰治",
                };
                db.Authors.Add(author4);

                var author5 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author5);

                var author6 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author6);
                db.SaveChanges();
            }

            //Books
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(book2);

                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);

                var author5 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book5 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = author5,
                };
                db.Books.Add(book5);

                var author6 = db.Authors.Single(a => a.Name == "太宰治");
                var book6 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = author6,
                };
                db.Books.Add(book6);

                var author7 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book7 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author7,
                };
                db.Books.Add(book7);

                var author8 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book8 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author8,
                };
                db.Books.Add(book8);
                db.SaveChanges();
            }
        }

        private static void Exercise13_1_2()
        {
            var db = new BooksDbContext();
            var books = db.Books.OrderBy(b => b.PublishedYear).ThenBy(b => b.Author.Name);
            Console.WriteLine("");
            Console.WriteLine("<書籍情報と著者名>");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}/{book.PublishedYear}/{book.Author.Name}");
            }
        }

        private static void Exercise13_1_3()
        {
            var db = new BooksDbContext();
            var most = db.Books.Where(s => s.Title.Length == db.Books.Max(d => d.Title.Length));
            Console.WriteLine("");
            Console.WriteLine("<一番文字数の多いタイトル>");
            foreach (var book in most)
            {
                Console.WriteLine($"{book.Title}");
            }

        }

        private static void Exercise13_1_4()
        {
            var db = new BooksDbContext();
            var old = db.Books.OrderBy(a => a.PublishedYear).Take(3);
            Console.WriteLine("");
            Console.WriteLine("<古い順に三冊>");
            foreach (var book in old)
            {
                Console.WriteLine($"{book.Title}/{book.Author.Name}");
            }
        }

        private static void Exercise13_1_5()
        {
            var db = new BooksDbContext();
            var bo = db.Books.OrderByDescending(a => a.Author.Birthday);
            Console.WriteLine("");
            Console.WriteLine("<著者ごとの書籍タイトル・発行年>");
            foreach (var book in bo)
            {
                Console.WriteLine($"{book.Title}/{book.PublishedYear}");
            }
            Console.WriteLine("");
        }

        //章末以前
        #region

        // List 13-12
        private static void DeleteBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        // List 13-11
        private static void UpdateBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-5
        static void InsertBooks() 
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);


                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges();//データベースの更新
            }
        }

        // List 13-7
        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        // List 13-8
        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();
        }

        // List 13-9
        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);




                /*Exercise13_1_1*/
                var author3 = new Author
                {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author3);

                var author4 = new Author
                {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author4);
                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);




                /*Exercise13_1_1*/
                var author3 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book3 = new Book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author3,
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "川端康成");
                var book4 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author4,
                };
                db.Books.Add(book4);

                var author5 = db.Authors.Single(a => a.Name == "菊池寛");
                var book5 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author5,
                };
                db.Books.Add(book5);

                var author6 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book6 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author6,
                };
                db.Books.Add(book6);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
