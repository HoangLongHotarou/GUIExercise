using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theory2.Models;

namespace Theory2.Component
{
    public partial class NewsControl : UserControl
    {
        public NewsControl()
        {
            InitializeComponent();
        }

        public void setArticle(Article news)
        {
            lblTitle.Text = news.Title;
            lblDescription.Text = news.Description;
            lblPubishDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
            lblLink.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height-1);
        }
    }
}
