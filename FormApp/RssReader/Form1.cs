using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();

        public Form1() {
            InitializeComponent();
        }



        private void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();  //リストボックスのクリア
            try {
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(tbUrl.Text);
                    XDocument xdoc = XDocument.Load(url);

                    ItemDatas = xdoc.Root.Descendants("item")
                                            .Select(x => new ItemData {
                                                Title = (string)x.Element("title"),
                                                Link = (string)x.Element("link"),
                                            }).ToList();

                    foreach (var node in ItemDatas) {
                        lbRssTitle.Items.Add(node.Title);
                    }
                }
            }
            catch(ArgumentException) {
                return;
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
        }

        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }

        private void rbSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }

        private void rbScience_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/science.xml";
        }

        private void rbIt_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void btRegistration_Click(object sender, EventArgs e) {

        }

        private void cbRegistrationList_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
