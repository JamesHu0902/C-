namespace CH11test3
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
            this.cbo = new System.Windows.Forms.ComboBox();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cbo
            // 
            this.cbo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "動作",
            "布袋戲",
            "卡通"});
            this.cbo.Location = new System.Drawing.Point(115, 29);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(182, 32);
            this.cbo.TabIndex = 0;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // clb
            // 
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(115, 71);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(182, 208);
            this.clb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.cbo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.CheckedListBox clb;
    }
}

