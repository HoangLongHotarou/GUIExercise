using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Theory2.Models;

namespace Theory2.RssRead
{
    public class NewsParser
    {
        public List<Article> ParserXML(string xmlContent)
        {
            var document = new XmlDocument();
            document.LoadXml(xmlContent);

            var articles = new List<Article>();
            var itemNodes = document.SelectNodes("//item");

            foreach (XmlNode node in itemNodes)
            {
                var news = new Article()
                {
                    Title = node.SelectSingleNode("title").InnerText,
                    Description = StripHtml(node.SelectSingleNode("description").InnerText),
                    Link = node.SelectSingleNode("link").InnerText,
                    PublishedDate = ParseDate(node.SelectSingleNode("pubDate").InnerText)
                };
                articles.Add(news);
            }
            return articles;
        }

        internal List<Article> ParserXML()
        {
            throw new NotImplementedException();
        }

        private DateTime ParseDate(string innerText)
        {
            try
            {
                return DateTime.Parse(innerText);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }

        private string StripHtml(string innerText)
        {
            return Regex.Replace(innerText, "<.*?>", String.Empty).Trim();
        }
    }
}
