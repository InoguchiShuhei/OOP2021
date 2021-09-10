﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section02
{
    class Program
    {
        static void Main(string[] args)
        {

            var xdoc = XDocument.Load("novelists.xml");
            var elements = xdoc.Root.Elements()
                                    .Where(x => x.Element("name").Value == "太宰 治");
            elements.Remove();
            xdoc.Save("novelists.xml"); //XMLファイルへの保存


            //string elmstring =
            //  @"<novelist>
            //    <name kana=""きくち かん"">菊池 寛</name>
            //    <birth>1888-12-26</birth>
            //    <death>1948-03-06</death>
            //    <masterpieces>
            //    <title>恩讐の彼方に</title>
            //    <title>真珠夫人</title>
            //    </masterpieces>
            //    </novelist>";

            //XElement element = XElement.Parse(elmstring);
            //xdoc.Root.Add(element);
        }
    }
}