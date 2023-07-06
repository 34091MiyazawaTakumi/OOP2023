using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var today = DateTime.Now;
            var day = today - dtp;
            tbMessage.Text = "入力した日にちから" + day.Days + "日経過";
        }

        private void Form1_Load(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH:mm:ss");
            tmTimeDisp.Start();
        }

        private void btForwardYear_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddYears(-1);
            dtpDate.Text = year.ToString();
        }

        private void bt_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddYears(1);
            dtpDate.Text = year.ToString();
        }

        private void btForwardMonth_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddMonths(-1);
            dtpDate.Text = year.ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddMonths(1);
            dtpDate.Text = year.ToString();
        }

        private void btForwardDay_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddDays(-1);
            dtpDate.Text = year.ToString();
        }

        private void button6_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddDays(1);
            dtpDate.Text = year.ToString();
        }

        private void btAge_Click(object sender, EventArgs e) {
            //var dtp = dtpDate.Value;
            //var today = DateTime.Now;
            //var age = (today - dtp).Days / 365;
            //tbMessage.Text = age.ToString() + "歳です。";
            var age = GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "貴方の年齢は" + age + "歳です。";
        }

        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH:mm:ss");
        }
    }
}
