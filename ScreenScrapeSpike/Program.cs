using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScreenScrapeSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://wol.jw.org/en/wol/dt/r1/lp-e";
            
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var dateText = doc.DocumentNode.SelectSingleNode("//p[@class='ss']").InnerText;
            var header = doc.DocumentNode.SelectSingleNode("//p[@class='sa']").InnerText;
            var body =doc.DocumentNode.SelectSingleNode("//p[@class='sb']").InnerText; 
            
            Console.WriteLine(dateText);
            Console.WriteLine(header);
            Console.WriteLine(body);
            Console.Read();
        }
    }
}
