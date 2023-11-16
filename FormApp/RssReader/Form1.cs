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
        

        Dictionary<string, string> registrationDict = new Dictionary<string, string>();

        public Form1() {
            InitializeComponent();
        }

        class registrationSet {
            public string Url { get; set; }
            public string Name { get; set; }

            public registrationSet(string Url, string Name) {
                this.Url = Url;
                this.Name = Name;
            }
            public override string ToString() {
                return Name;
            }
        }

        private void btGet_Click(object sender, EventArgs e) {
            urlGet();
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
                tbRegistrationName.Text = ItemDatas[lbRssTitle.SelectedIndex].Title;
                tbRegistrationUrl.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
        }

        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
            urlGet();
        }

        private void rbSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
            urlGet();
        }

        private void rbScience_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/science.xml";
            urlGet();
        }

        private void rbIt_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
            urlGet();
        }

        private void btRegistration_Click(object sender, EventArgs e) {
            if (!tbRegistrationName.Text.Equals("") && !tbRegistrationUrl.Text.Equals("")) {
                if (lbRssTitle.Items.Count != 0 && tbRegistrationName.Text == null && tbRegistrationUrl == null) {
                    tbRegistrationName.Text = lbRssTitle.SelectedItem.ToString();
                    tbRegistrationUrl.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;
                }

                registrationSet Registration = new registrationSet(tbRegistrationUrl.Text, tbRegistrationName.Text);
                if (registrationDict.ContainsKey(tbRegistrationUrl.Text) || registrationDict.ContainsValue(tbRegistrationName.Text)) {
                    lbMessage.Text = "名前かURLが重複しています。";
                }
                else {
                    cbRegistrationList.Items.Add(Registration);
                    registrationDict.Add(tbRegistrationUrl.Text, tbRegistrationName.Text);
                    cbRegistrationList.SelectedItem = Registration;
                    lbMessage.Text = "登録しました。";
                }
            }
            else {
                lbMessage.Text = "名前とURLを入力してください。";
            }
        }

        private void cbRegistrationList_SelectedIndexChanged(object sender, EventArgs e) {
            registrationSet Registration = (registrationSet)cbRegistrationList.SelectedItem;
            if (Registration.Url.Contains("pickup")) {
                wbBrowser.Navigate(Registration.Url);
            }
            else {
                tbUrl.Text = Registration.Url.ToString();
            }
        }

        private void btAllClear_Click(object sender, EventArgs e) {
            tbUrl.Text = "";
            lbRssTitle.Items.Clear();
            wbBrowser.DocumentText = "";
            lbMessage.Text = "すべてをクリアしました。";
        }

        private void btDelete_Click(object sender, EventArgs e) {
            try {
                registrationSet Registration = (registrationSet)cbRegistrationList.SelectedItem;
                registrationDict.Remove(Registration.Url);
                cbRegistrationList.Items.RemoveAt(cbRegistrationList.SelectedIndex);
                cbRegistrationList.Text = "";
                tbRegistrationName.Text = "";
                tbRegistrationUrl.Text = "";
                lbMessage.Text = "お気に入りを削除しました。";
            }
            catch (ArgumentOutOfRangeException) {
                lbMessage.Text = "削除する項目がありません。";
            }
        }

        private void urlGet() {
            lbRssTitle.Items.Clear();  //リストボックスのクリア

            if (tbUrl.TextLength != 0) {
                using (var wc = new WebClient()) {
                    try {
                        lbMessage.Text = "";
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
                    catch (WebException) {
                        lbMessage.Text = "正しいURLを入力してください。";
                        tbUrl.Text = "";
                    }
                }
            }
            else {
                lbMessage.Text = "URLを入力してください。";
            }
        }

        private void btNext_Click(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(ItemDatas[++lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
        }

        private void btPrev_Click(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(ItemDatas[--lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e) {
            wbBrowser.Refresh();
            lbMessage.Text = "リフレッシュ済み";
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbUrl.Text = "";
            lbMessage.Text = "URLをクリアしました。";
        }
    }
}
