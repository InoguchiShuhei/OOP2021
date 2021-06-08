using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

          /*
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
          */


            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };


          /*
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine("-----");
          */

            // 出来た人①
            Exercise2_5(names);
            Console.WriteLine("-----");

            // 出来た人②
            Exercise2_6(names);
        }

        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);

            if (exist)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));            
        }

        private static void Exercise1_3(List<int> numbers) {
            var query = numbers.Where(n => 50 <= n);
            foreach(var item in query)
                Console.WriteLine(item);
        }

        private static void Exercise1_4(List<int> numbers) {
            var list = numbers.Select(n => n * 2).ToList();            
            foreach (var item in list)
                Console.WriteLine(item);
        

            
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力してください");
            var line = Console.ReadLine();
            int index = names.FindIndex(n => n == line);
            Console.WriteLine(index);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(n => n.Contains('o'));            
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var name = names.Where(n => n.Contains('o'));
            foreach(var item in name)
            Console.WriteLine(item);
        }

        private static void Exercise2_4(List<string> names) {
            var num = names.Where(n => n[0] == 'B').Select(n => n.Length);
            foreach(var item in num)
            Console.WriteLine(item);
        }

        private static void Exercise2_5(List<string> names) {
            int count = 0;

            names.ForEach(n => n.Count(c => char.IsLower(c)));

            //foreach(var name in names) {
            //    count += name.Count(c => char.IsLower(c));                
            //}
            Console.WriteLine(count);
        }

        private static void Exercise2_6(List<string> names) {
            
        }
    }  
}
