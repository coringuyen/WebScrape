using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Assignment
{
    public partial class Form1 : Form
    {
        List<string> audio = new List<string>();
        WebBrowser gotoweb = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
            webScrape();
        }

        private void webScrape()
        {
            HtmlWeb get = new HtmlWeb();
            var doc = get.Load("http://www.realmofdarkness.net/sb/bane");
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//audio");
            foreach (HtmlNode node in nodes)
            {
                string url = node.InnerHtml.Remove(0, 13);
                url = url.Remove(url.Length - 11);
                audio.Add(url);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gotoweb.Navigate(audio[2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gotoweb.Navigate(audio[8]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gotoweb.Navigate(audio[28]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gotoweb.Navigate(audio[43]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gotoweb.Navigate(audio[56]);
        }

       
    }
}
