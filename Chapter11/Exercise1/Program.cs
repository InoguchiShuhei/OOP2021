using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var ballsports = xdoc.Root.Elements();
            foreach (var xballsport in ballsports)
            {
                var xname = xballsport.Element("name");
                var teammembers = xballsport.Element("teammembers");
                Console.WriteLine("{0} {1}", xname.Value, teammembers.Value);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);

        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);

        }
    }
}
