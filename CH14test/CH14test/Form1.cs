using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH14test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int oldX, oldY;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //oldX = e.X;
            //oldY = e.Y;
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                button1.Left = e.X;
                button1.Top = e.Y;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
