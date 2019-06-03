using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIMutilFormEx
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 拉霸遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBar f = new frmBar();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void 記憶大考驗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemory f = new frmMemory();
            f.MdiParent = this;
            f.Show();
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
