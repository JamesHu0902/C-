namespace WinToolStrip
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCls = new System.Windows.Forms.ToolStripButton();
            this.tsbBullet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFontColor = new System.Windows.Forms.ToolStripSplitButton();
            this.黑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cboSize2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.黑ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.紅ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.綠ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.藍ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tsbCls,
            this.tsbBullet,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.cboSize,
            this.toolStripSeparator3,
            this.tsbFontColor,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(412, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(35, 22);
            this.tsbOpen.Text = "開檔";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(35, 22);
            this.tsbSave.Text = "存檔";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCls
            // 
            this.tsbCls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCls.Image = ((System.Drawing.Image)(resources.GetObject("tsbCls.Image")));
            this.tsbCls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCls.Name = "tsbCls";
            this.tsbCls.Size = new System.Drawing.Size(35, 22);
            this.tsbCls.Text = "清除";
            this.tsbCls.Click += new System.EventHandler(this.tsbCls_Click);
            // 
            // tsbBullet
            // 
            this.tsbBullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBullet.Image = ((System.Drawing.Image)(resources.GetObject("tsbBullet.Image")));
            this.tsbBullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBullet.Name = "tsbBullet";
            this.tsbBullet.Size = new System.Drawing.Size(59, 22);
            this.tsbBullet.Text = "項目符號";
            this.tsbBullet.Click += new System.EventHandler(this.tsbBullet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel2.Text = "字型大小";
            // 
            // cboSize
            // 
            this.cboSize.Items.AddRange(new object[] {
            "9",
            "10",
            "12",
            "14",
            "16"});
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(75, 25);
            this.cboSize.Text = "9";
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFontColor
            // 
            this.tsbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFontColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑ToolStripMenuItem,
            this.紅ToolStripMenuItem,
            this.綠ToolStripMenuItem,
            this.藍ToolStripMenuItem});
            this.tsbFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontColor.Image")));
            this.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontColor.Name = "tsbFontColor";
            this.tsbFontColor.Size = new System.Drawing.Size(71, 22);
            this.tsbFontColor.Text = "字型色彩";
            // 
            // 黑ToolStripMenuItem
            // 
            this.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            this.黑ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.黑ToolStripMenuItem.Text = "黑";
            this.黑ToolStripMenuItem.Click += new System.EventHandler(this.黑ToolStripMenuItem_Click);
            // 
            // 紅ToolStripMenuItem
            // 
            this.紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            this.紅ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.紅ToolStripMenuItem.Text = "紅";
            this.紅ToolStripMenuItem.Click += new System.EventHandler(this.紅ToolStripMenuItem_Click);
            // 
            // 綠ToolStripMenuItem
            // 
            this.綠ToolStripMenuItem.Name = "綠ToolStripMenuItem";
            this.綠ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.綠ToolStripMenuItem.Text = "綠";
            this.綠ToolStripMenuItem.Click += new System.EventHandler(this.綠ToolStripMenuItem_Click);
            // 
            // 藍ToolStripMenuItem
            // 
            this.藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            this.藍ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.藍ToolStripMenuItem.Text = "藍";
            this.藍ToolStripMenuItem.Click += new System.EventHandler(this.藍ToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(273, 140);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.cboSize2,
            this.toolStripSplitButton1,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(412, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "開檔";
            this.toolStripButton1.ToolTipText = "開檔";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton2.Text = "存檔";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel3.Text = "字型大小";
            // 
            // cboSize2
            // 
            this.cboSize2.Items.AddRange(new object[] {
            "9",
            "10",
            "12",
            "14",
            "16"});
            this.cboSize2.Name = "cboSize2";
            this.cboSize2.Size = new System.Drawing.Size(75, 25);
            this.cboSize2.Text = "9";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑ToolStripMenuItem1,
            this.紅ToolStripMenuItem1,
            this.綠ToolStripMenuItem1,
            this.藍ToolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton1.Text = "字體色彩";
            // 
            // 黑ToolStripMenuItem1
            // 
            this.黑ToolStripMenuItem1.Name = "黑ToolStripMenuItem1";
            this.黑ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.黑ToolStripMenuItem1.Text = "黑";
            // 
            // 紅ToolStripMenuItem1
            // 
            this.紅ToolStripMenuItem1.Name = "紅ToolStripMenuItem1";
            this.紅ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.紅ToolStripMenuItem1.Text = "紅";
            // 
            // 綠ToolStripMenuItem1
            // 
            this.綠ToolStripMenuItem1.Name = "綠ToolStripMenuItem1";
            this.綠ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.綠ToolStripMenuItem1.Text = "綠";
            // 
            // 藍ToolStripMenuItem1
            // 
            this.藍ToolStripMenuItem1.Name = "藍ToolStripMenuItem1";
            this.藍ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.藍ToolStripMenuItem1.Text = "藍";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 248);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCls;
        private System.Windows.Forms.ToolStripButton tsbBullet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton tsbFontColor;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cboSize2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 綠ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 藍ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

