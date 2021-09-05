using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Theory2.Models;

namespace Theory2.RssRead
{
    public class RssReader
    {
        private readonly NewsParser _parser;

        public RssReader(NewsParser parser)
        {
            _parser = parser;
        }

        public List<Article> GetNews(string rssLink)
        {
            var feedData = DownloadFeed(rssLink);
            return _parser.ParserXML(feedData);
        }

        private string DownloadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            return client.DownloadString(rssLink);
        }
    }
}
