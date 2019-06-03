namespace MDIMutilFormEx
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲種類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拉霸遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.記憶大考驗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲種類ToolStripMenuItem,
            this.離開ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲種類ToolStripMenuItem
            // 
            this.遊戲種類ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拉霸遊戲ToolStripMenuItem,
            this.記憶大考驗ToolStripMenuItem});
            this.遊戲種類ToolStripMenuItem.Name = "遊戲種類ToolStripMenuItem";
            this.遊戲種類ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.遊戲種類ToolStripMenuItem.Text = "遊戲種類";
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // 拉霸遊戲ToolStripMenuItem
            // 
            this.拉霸遊戲ToolStripMenuItem.Name = "拉霸遊戲ToolStripMenuItem";
            this.拉霸遊戲ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.拉霸遊戲ToolStripMenuItem.Text = "拉霸遊戲";
            this.拉霸遊戲ToolStripMenuItem.Click += new System.EventHandler(this.拉霸遊戲ToolStripMenuItem_Click);
            // 
            // 記憶大考驗ToolStripMenuItem
            // 
            this.記憶大考驗ToolStripMenuItem.Name = "記憶大考驗ToolStripMenuItem";
            this.記憶大考驗ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.記憶大考驗ToolStripMenuItem.Text = "記憶大考驗";
            this.記憶大考驗ToolStripMenuItem.Click += new System.EventHandler(this.記憶大考驗ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遊戲種類ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拉霸遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 記憶大考驗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
    }
}