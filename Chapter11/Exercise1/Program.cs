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
            var firstplayed = xdoc.Root.Elements().OrderBy(x => (string)(x.Element("firstplayed")));
            foreach (var xballsport in firstplayed)
            {                
                var xname = xballsport.Element("name");
                XAttribute xkanji = xname.Attribute("kanji");
                Console.WriteLine("{0}", xkanji.Value);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var ballsports = xdoc.Root.Elements()
                                      .Select(x => new
                                      {
                                          Name = x.Element("name").Value,
                                          Teammembers = x.Element("teammembers").Value
                                      })
                                     .OrderByDescending(x => int.Parse(x.Teammembers))
                                     .First();

            Console.WriteLine("{0}", ballsports.Name);
        }
    }
}
