
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(22, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(656, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(684, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(240, 49);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(519, 172);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(22, 227);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(945, 474);
            this.wbBrowser.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIt);
            this.groupBox1.Controls.Add(this.rbScience);
            this.groupBox1.Controls.Add(this.rbSports);
            this.groupBox1.Controls.Add(this.rbEntertainment);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(22, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カテゴリごとのニュース";
            // 
            // rbIt
            // 
            this.rbIt.AutoSize = true;
            this.rbIt.Location = new System.Drawing.Point(22, 104);
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
            this.rbSports.Size = new System.Drawing.Size(88, 23);
            this.rbSports.TabIndex = 11;
            this.rbSports.TabStop = true;
            this.rbSports.Text = "スポーツ";
            this.rbSports.UseVisualStyleBackColor = true;
            this.rbSports.CheckedChanged += new System.EventHandler(this.rbSports_CheckedChanged);
            // 
            // rbEntertainment
            // 
            this.rbEntertainment.AutoSize = true;
            this.rbEntertainment.Location = new System.Drawing.Point(22, 28);
            this.rbEntertainment.Name = "rbEntertainment";
            this.rbEntertainment.Size = new System.Drawing.Size(81, 23);
            this.rbEntertainment.TabIndex = 10;
            this.rbEntertainment.TabStop = true;
            this.rbEntertainment.Text = "エンタメ";
            this.rbEntertainment.UseVisualStyleBackColor = true;
            this.rbEntertainment.CheckedChanged += new System.EventHandler(this.rbEntertainment_CheckedChanged);
            // 
            // btRegistration
            // 
            this.btRegistration.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRegistration.Location = new System.Drawing.Point(892, 189);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(75, 30);
            this.btRegistration.TabIndex = 7;
            this.btRegistration.Text = "登録";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // tbRegistrationName
            // 
            this.tbRegistrationName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegistrationName.Location = new System.Drawing.Point(803, 36);
            this.tbRegistrationName.Name = "tbRegistrationName";
            this.tbRegistrationName.Size = new System.Drawing.Size(164, 26);
            this.tbRegistrationName.TabIndex = 8;
            // 
            // tbRegistrationUrl
            // 
            this.tbRegistrationUrl.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegistrationUrl.Location = new System.Drawing.Point(803, 93);
            this.tbRegistrationUrl.Name = "tbRegistrationUrl";
            this.tbRegistrationUrl.Size = new System.Drawing.Size(164, 26);
            this.tbRegistrationUrl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(784, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(784, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "URL";
            // 
            // cbRegistrationList
            // 
            this.cbRegistrationList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegistrationList.FormattingEnabled = true;
            this.cbRegistrationList.Location = new System.Drawing.Point(803, 151);
            this.cbRegistrationList.Name = "cbRegistrationList";
            this.cbRegistrationList.Size = new System.Drawing.Size(164, 27);
            this.cbRegistrationList.TabIndex = 12;
            this.cbRegistrationList.SelectedIndexChanged += new System.EventHandler(this.cbRegistrationList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(784, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "登録リスト";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 713);
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
            this.Text = "Form1";
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
    }
}

