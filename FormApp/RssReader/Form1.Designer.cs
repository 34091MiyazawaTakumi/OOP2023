
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIt = new System.Windows.Forms.RadioButton();
            this.rbScience = new System.Windows.Forms.RadioButton();
            this.rbSports = new System.Windows.Forms.RadioButton();
            this.rbEntertainment = new System.Windows.Forms.RadioButton();
            this.btRegistration = new System.Windows.Forms.Button();
            this.tbRegistrationName = new System.Windows.Forms.TextBox();
            this.tbRegistrationUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegistrationList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAllClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(22, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(525, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGet.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(553, 14);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 16;
            this.lbRssTitle.Location = new System.Drawing.Point(229, 59);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(480, 164);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(22, 263);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(990, 474);
            this.wbBrowser.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIt);
            this.groupBox1.Controls.Add(this.rbScience);
            this.groupBox1.Controls.Add(this.rbSports);
            this.groupBox1.Controls.Add(this.rbEntertainment);
            this.groupBox1.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(22, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カテゴリごとのニュース";
            // 
            // rbIt
            // 
            this.rbIt.AutoSize = true;
            this.rbIt.Location = new System.Drawing.Point(22, 103);
            this.rbIt.Name = "rbIt";
            this.rbIt.Size = new System.Drawing.Size(43, 23);
            this.rbIt.TabIndex = 12;
            this.rbIt.TabStop = true;
            this.rbIt.Text = "IT";
            this.rbIt.UseVisualStyleBackColor = true;
            this.rbIt.CheckedChanged += new System.EventHandler(this.rbIt_CheckedChanged);
            // 
            // rbScience
            // 
            this.rbScience.AutoSize = true;
            this.rbScience.Location = new System.Drawing.Point(22, 140);
            this.rbScience.Name = "rbScience";
            this.rbScience.Size = new System.Drawing.Size(65, 23);
            this.rbScience.TabIndex = 14;
            this.rbScience.TabStop = true;
            this.rbScience.Text = "科学";
            this.rbScience.UseVisualStyleBackColor = true;
            this.rbScience.CheckedChanged += new System.EventHandler(this.rbScience_CheckedChanged);
            // 
            // rbSports
            // 
            this.rbSports.AutoSize = true;
            this.rbSports.Location = new System.Drawing.Point(22, 64);
            this.rbSports.Name = "rbSports";
            this.rbSports.Size = new System.Drawing.Size(96, 23);
            this.rbSports.TabIndex = 11;
            this.rbSports.TabStop = true;
            this.rbSports.Text = "スポーツ";
            this.rbSports.UseVisualStyleBackColor = true;
            this.rbSports.CheckedChanged += new System.EventHandler(this.rbSports_CheckedChanged);
            // 
            // rbEntertainment
            // 
            this.rbEntertainment.AutoSize = true;
            this.rbEntertainment.Location = new System.Drawing.Point(22, 25);
            this.rbEntertainment.Name = "rbEntertainment";
            this.rbEntertainment.Size = new System.Drawing.Size(90, 23);
            this.rbEntertainment.TabIndex = 10;
            this.rbEntertainment.TabStop = true;
            this.rbEntertainment.Text = "エンタメ";
            this.rbEntertainment.UseVisualStyleBackColor = true;
            this.rbEntertainment.CheckedChanged += new System.EventHandler(this.rbEntertainment_CheckedChanged);
            // 
            // btRegistration
            // 
            this.btRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRegistration.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRegistration.Location = new System.Drawing.Point(856, 225);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(75, 30);
            this.btRegistration.TabIndex = 7;
            this.btRegistration.Text = "登録";
            this.btRegistration.UseVisualStyleBackColor = false;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // tbRegistrationName
            // 
            this.tbRegistrationName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegistrationName.Location = new System.Drawing.Point(746, 94);
            this.tbRegistrationName.Name = "tbRegistrationName";
            this.tbRegistrationName.Size = new System.Drawing.Size(266, 26);
            this.tbRegistrationName.TabIndex = 8;
            // 
            // tbRegistrationUrl
            // 
            this.tbRegistrationUrl.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegistrationUrl.Location = new System.Drawing.Point(746, 145);
            this.tbRegistrationUrl.Name = "tbRegistrationUrl";
            this.tbRegistrationUrl.Size = new System.Drawing.Size(266, 26);
            this.tbRegistrationUrl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(725, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(725, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "URL";
            // 
            // cbRegistrationList
            // 
            this.cbRegistrationList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegistrationList.FormattingEnabled = true;
            this.cbRegistrationList.Location = new System.Drawing.Point(746, 196);
            this.cbRegistrationList.Name = "cbRegistrationList";
            this.cbRegistrationList.Size = new System.Drawing.Size(266, 27);
            this.cbRegistrationList.TabIndex = 12;
            this.cbRegistrationList.SelectedIndexChanged += new System.EventHandler(this.cbRegistrationList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(725, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "登録リスト";
            // 
            // btAllClear
            // 
            this.btAllClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAllClear.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAllClear.Location = new System.Drawing.Point(591, 225);
            this.btAllClear.Name = "btAllClear";
            this.btAllClear.Size = new System.Drawing.Size(118, 31);
            this.btAllClear.TabIndex = 14;
            this.btAllClear.Text = "オールクリア";
            this.btAllClear.UseVisualStyleBackColor = false;
            this.btAllClear.Click += new System.EventHandler(this.btAllClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDelete.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(937, 225);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 30);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btPrev
            // 
            this.btPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPrev.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPrev.Location = new System.Drawing.Point(22, 227);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(112, 30);
            this.btPrev.TabIndex = 16;
            this.btPrev.Text = "前の記事へ";
            this.btPrev.UseVisualStyleBackColor = false;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btNext.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNext.Location = new System.Drawing.Point(166, 227);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(112, 30);
            this.btNext.TabIndex = 17;
            this.btNext.Text = "次の記事へ";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btClear.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(634, 14);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 29);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefresh.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRefresh.Location = new System.Drawing.Point(543, 227);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(42, 28);
            this.btRefresh.TabIndex = 19;
            this.btRefresh.Text = "🔁";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("HG創英ﾌﾟﾚｾﾞﾝｽEB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMessage.Location = new System.Drawing.Point(725, 20);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(269, 19);
            this.lbMessage.TabIndex = 20;
            this.lbMessage.Text = "                          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1038, 749);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAllClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRegistrationList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRegistrationUrl);
            this.Controls.Add(this.tbRegistrationName);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "RssReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIt;
        private System.Windows.Forms.RadioButton rbScience;
        private System.Windows.Forms.RadioButton rbSports;
        private System.Windows.Forms.RadioButton rbEntertainment;
        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.TextBox tbRegistrationName;
        private System.Windows.Forms.TextBox tbRegistrationUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRegistrationList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAllClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label lbMessage;
    }
}

