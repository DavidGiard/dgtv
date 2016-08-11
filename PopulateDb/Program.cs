using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PopulateDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var rssLocation = @"C:\development\dgtv\Rss\RSS.xml";


            var xml = new XmlDocument();
            xml.Load(rssLocation);

            XmlNode channelNode = xml.DocumentElement.SelectSingleNode("channel");

            XmlNodeList itemNodes = channelNode.SelectNodes("item");

            foreach(XmlNode itemNode in itemNodes)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("title");
                var title = titleNode.InnerText;

                XmlNode descriptionNode = itemNode.SelectSingleNode("description");
                var description = descriptionNode.InnerText;

                XmlNode pubDateNode = itemNode.SelectSingleNode("pubDate");
                var pubDateAsText = pubDateNode.InnerText;
                var pubDate = Convert.ToDateTime(pubDateAsText);

                var namespaceManager = new XmlNamespaceManager(xml.NameTable);
                namespaceManager.AddNamespace("media", "http://search.yahoo.com/mrss/");
                namespaceManager.PushScope();
                XmlNodeList mediaThumbnailNodes = itemNode.SelectNodes("thumbnail", namespaceManager);

                Console.WriteLine(mediaThumbnailNodes.Count);

                Console.WriteLine(title);
                Console.WriteLine(description);
                Console.WriteLine(pubDate);

                Console.WriteLine();


            }

            

            Console.WriteLine("Done. Press ENTER to close");
            Console.ReadLine();
        }

        int GetEpisodeNumber (string title)
        {
            string[] words = title.Split();
            string episodeNumberAsString = words[1];
            int episodeNumber = Convert.ToInt32(episodeNumberAsString);
            return episodeNumber;
         }

        string GetGuests (string title)
        {
            string[] wordsArray = title.Split();
            int colonPosition = Array.IndexOf(wordsArray, ":");
            int onPosition = Array.IndexOf(wordsArray, "on");
            guestNameWords = new string[colonPosition - onPosition]();
            string [] guestNames = wordsArray.


        }
    }

    
}
