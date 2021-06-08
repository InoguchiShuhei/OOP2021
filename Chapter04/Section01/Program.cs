using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            int count = 0;

            Console.WriteLine($"後置 : {count++}");

            Console.WriteLine($"前置 : {++count}");

        }
    }
}

