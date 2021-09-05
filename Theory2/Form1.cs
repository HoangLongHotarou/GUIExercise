using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theory2.Component;
using Theory2.Models;

namespace Theory2
{
    public partial class Form1 : Form
    {
        private readonly NewsFeedManager _newsManager;

        public object Arrays { get; private set; }

        public Form1(NewsFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFeedOnTreeView(_newsManager.GetNewsFeed());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (twPublisher.SelectedNode == null) return;
            if (twPublisher.SelectedNode.Level == 0)
            {
                _newsManager.RemovePublisher(twPublisher.SelectedNode.Text);
            }
            else
            {
                _newsManager.RemoveCategory(twPublisher.SelectedNode.Parent.Text, twPublisher.SelectedNode.Text);
            }
            twPublisher.SelectedNode.Remove();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFeedForm dialog = new AddFeedForm(_newsManager);
            dialog.ShowDialog();
            if (dialog.HasChanged)
            {
                _newsManager.SaveChanges();
                ShowFeedOnTreeView(_newsManager.GetNewsFeed());
            }
        }

        private void twPublisher_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnlNews.Controls.Clear();
            if (e.Node.Level == 1)
            {
                var articles = _newsManager.GetNews(e.Node.Parent.Text,e.Node.Text);
                var articlesSort = articles.OrderBy(x => x.PublishedDate.Date).ToList();
                foreach (var article in articlesSort)
                {
                    var item = new NewsControl();
                    item.Size = new Size(670, 140);
                    item.Dock = DockStyle.Top;
                    item.setArticle(article);
                    pnlNews.Controls.Add(item);
                }
            }
        }

        private void ShowFeedOnTreeView(List<Publisher> publishers)
        {
            twPublisher.Nodes.Clear();
            pnlNews.Controls.Clear();
            foreach (var publisher in publishers)
            {
                var publisherNode = twPublisher.Nodes.Add(publisher.Name);
                foreach (var category in publisher.Categories)
                {
                    publisherNode.Nodes.Add(category.Name);
                }
            }
            twPublisher.ExpandAll();
        }
    }
}
