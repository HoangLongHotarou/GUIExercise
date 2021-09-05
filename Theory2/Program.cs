using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theory2.IO;
using Theory2.RssRead;

namespace Theory2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            INewsRepository newsRepository = new NewsRepository();
            NewsParser newsParser = new NewsParser();
            RssReader rssReader = new RssReader(newsParser);
            NewsFeedManager newsManager = new NewsFeedManager(newsRepository,rssReader);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(newsManager));
        }
    }
}
