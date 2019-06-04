namespace CH11test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chengtext = new System.Windows.Forms.Label();
            this.cbofont = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.斜體 = new System.Windows.Forms.RadioButton();
            this.底線 = new System.Windows.Forms.RadioButton();
            this.正常 = new System.Windows.Forms.RadioButton();
            this.粗體 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chengtext
            // 
            this.chengtext.AutoSize = true;
            this.chengtext.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chengtext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chengtext.Location = new System.Drawing.Point(138, 75);
            this.chengtext.Name = "chengtext";
            this.chengtext.Size = new System.Drawing.Size(199, 45);
            this.chengtext.TabIndex = 0;
            this.chengtext.Text = "cheng text";
            // 
            // cbofont
            // 
            this.cbofont.AutoCompleteCustomSource.AddRange(new string[] {
            "微軟正黑體",
            "新細明體",
            "標楷體"});
            this.cbofont.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbofont.FormattingEnabled = true;
            this.cbofont.Items.AddRange(new object[] {
            "微軟正黑體",
            "標楷體",
            "新細明體"});
            this.cbofont.Location = new System.Drawing.Point(146, 157);
            this.cbofont.Name = "cbofont";
            this.cbofont.Size = new System.Drawing.Size(182, 32);
            this.cbofont.TabIndex = 1;
            this.cbofont.SelectedIndexChanged += new System.EventHandler(this.cbofont_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Items.AddRange(new object[] {
            "黑色",
            "紅色",
            "黃色",
            "藍色",
            "綠色"});
            this.listBox1.Location = new System.Drawing.Point(146, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 58);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.斜體);
            this.groupBox1.Controls.Add(this.底線);
            this.groupBox1.Controls.Add(this.正常);
            this.groupBox1.Controls.Add(this.粗體);
            this.groupBox1.Location = new System.Drawing.Point(441, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "樣式";
            // 
            // 斜體
            // 
            this.斜體.AutoSize = true;
            this.斜體.Location = new System.Drawing.Point(27, 105);
            this.斜體.Name = "斜體";
            this.斜體.Size = new System.Drawing.Size(47, 16);
            this.斜體.TabIndex = 3;
            this.斜體.TabStop = true;
            this.斜體.Text = "斜體";
            this.斜體.UseVisualStyleBackColor = true;
            this.斜體.CheckedChanged += new System.EventHandler(this.斜體_CheckedChanged);
            // 
            // 底線
            // 
            this.底線.AutoSize = true;
            this.底線.Location = new System.Drawing.Point(151, 49);
            this.底線.Name = "底線";
            this.底線.Size = new System.Drawing.Size(47, 16);
            this.底線.TabIndex = 2;
            this.底線.TabStop = true;
            this.底線.Text = "底線";
            this.底線.UseVisualStyleBackColor = true;
            this.底線.CheckedChanged += new System.EventHandler(this.底線_CheckedChanged);
            // 
            // 正常
            // 
            this.正常.AutoSize = true;
            this.正常.Location = new System.Drawing.Point(151, 105);
            this.正常.Name = "正常";
            this.正常.Size = new System.Drawing.Size(47, 16);
            this.正常.TabIndex = 1;
            this.正常.TabStop = true;
            this.正常.Text = "正常";
            this.正常.UseVisualStyleBackColor = true;
            this.正常.CheckedChanged += new System.EventHandler(this.正常_CheckedChanged);
            // 
            // 粗體
            // 
            this.粗體.AutoSize = true;
            this.粗體.Location = new System.Drawing.Point(27, 49);
            this.粗體.Name = "粗體";
            this.粗體.Size = new System.Drawing.Size(47, 16);
            this.粗體.TabIndex = 0;
            this.粗體.TabStop = true;
            this.粗體.Text = "粗體";
            this.粗體.UseVisualStyleBackColor = true;
            this.粗體.CheckedChanged += new System.EventHandler(this.粗體_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "粗體",
            "斜體",
            "底線"});
            this.checkedListBox1.Location = new System.Drawing.Point(441, 266);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(95, 94);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbofont);
            this.Controls.Add(this.chengtext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chengtext;
        private System.Windows.Forms.ComboBox cbofont;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton 斜體;
        private System.Windows.Forms.RadioButton 底線;
        private System.Windows.Forms.RadioButton 正常;
        private System.Windows.Forms.RadioButton 粗體;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

