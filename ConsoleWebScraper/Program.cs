using HtmlAgilityPack;
using ScrapySharp.Network;
using System;
using System.Linq;

namespace ConsoleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.cvonline.lt/darbo-skelbimai/informacines-technologijos/";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var coll = doc.DocumentNode.Descendants().Where(x => x.Name == "h2").ToList();
            coll.ForEach(c => Console.WriteLine($"{c.SelectSingleNode("a").InnerText}"));
        }
    }
}
