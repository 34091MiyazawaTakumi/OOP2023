﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var reports = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text.ToString(),
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text.ToString(),
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(reports);
            dgvCarReports.DataSource = CarReports;
        }

        private CarReport.MakerGroup getSelectedMaker() {

            return CarReport.MakerGroup.トヨタ;
        }
    }
}
