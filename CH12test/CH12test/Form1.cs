using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH12test
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //preson.Image = imageList1.Images[1];
            timer1.Interval = 100;
            timer1.Enabled = true;
            hScrollBar1.Minimum = 10;
            hScrollBar1.Maximum = 500;
            hScrollBar1.Value = timer1.Interval;
            label1.Text = "速度 : " + hScrollBar1.Value + " 毫秒/次";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            preson.Image = imageList1.Images[i];
            i++;
            if (i > 3) i = 0;
            preson.Left -= 15;
            if (preson.Left+preson.Width < 0) preson.Left = this.Width;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
            label1.Text = "速度 : " + hScrollBar1.Value + " 毫秒/次";
        }
    }
}
