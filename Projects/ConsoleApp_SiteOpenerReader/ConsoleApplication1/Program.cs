using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //HtmlWeb web = new HtmlWeb();    // for web downloading
            //HtmlDocument document = web.Load("http://www.c-sharpcorner.com"); // for loading from site
            /*try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://www.livescore.com/", @"C:\Users\Admin\Desktop\work\Crawler\file1.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            HtmlDocument document2 = new HtmlDocument();
            document2.Load(@"C:\Users\Admin\Desktop\work\Crawler\file1.txt");  
            HtmlNode[] nodes = document2.DocumentNode.SelectNodes("//a").ToArray();  
            foreach (HtmlNode item in nodes)  
            {
                var info = item.InnerHtml;
                if (info.Contains("Link 3")) 
                {
                    continue;
                }
                Console.WriteLine(item.InnerHtml);
            }
            Console.ReadLine();
            
            
            
            
            /*// Create web client.
            WebClient client = new WebClient();

            // Download string.
            string value = client.DownloadString("http://www.dotnetperls.com/");

            // Write values.
            Console.WriteLine("--- WebClient result ---");
            Console.WriteLine(value.Length);
            Console.WriteLine(value);*/
         
        }
    }
}
