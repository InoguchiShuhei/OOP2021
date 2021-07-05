using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("------");

            Exercise1_2(numbers);
            Console.WriteLine("------");

            Exercise1_3(numbers);
            Console.WriteLine("------");

            Exercise1_4(numbers);            
            Console.WriteLine("------");

            Exercise1_5(numbers);
            Console.WriteLine();
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max(x => x));
        }

        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach (var item in numbers.Skip(skip)) {
                Console.WriteLine(item);
            }            
        }

        private static void Exercise1_3(int[] numbers) {            
            foreach (var item in numbers) {
                var strnum = numbers.ToString();
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var ascnum = numbers.OrderBy(x => x).Take(3);
            foreach (var sort in ascnum) {
                Console.WriteLine(sort);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine(numbers.Distinct().Count(x => x > 10));
        }
    }
}
