﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //int ans = int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text);
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();
        }

        private void btPow_Click(object sender, EventArgs e) {
            int numx = (int)nudX.Value;
            int numy = (int)nudY.Value;
            int ans = 1;
            for (int i = 0; i < numy; i++)
            {
                ans = ans * numx;
            }
            tbResult.Text = ans.ToString();
        }
    }
}
