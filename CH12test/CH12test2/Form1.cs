using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH12test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> arr = new List<int>();
        int all = 500;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Enabled = false;
            pb1.Image = imageList1.Images[0];
            pb2.Image = imageList1.Images[0];
            pb3.Image = imageList1.Images[0];
            total.Text = all.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            //pb1.Image = imageList1.Images[n];
            //pb2.Image = imageList1.Images[n];
            //pb3.Image = imageList1.Images[n];
            arr.Clear();
            for (int i = 0; i < 3; i++)
            {
                int n = ran.Next(0, 4);
                arr.Add(n);
                //pb1.Image = imageList1.Images[n];
            }
            pb1.Image = imageList1.Images[arr[0]];
            pb2.Image = imageList1.Images[arr[1]];
            pb3.Image = imageList1.Images[arr[2]];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bit.Value>0 && all > 0)
            {
                timer1.Enabled = true;
                button1.Enabled = false;
                all -= int.Parse(bit.Value.ToString());
                total.Text = all.ToString();
            }
            else
            {
                MessageBox.Show("金額錯誤");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = true;
            if (arr[0] == arr[1] && arr[0] == arr[2] && arr[0] == 0)
            {
                MessageBox.Show("中獎了!! 賺 "+(bit.Value*5).ToString() + " 元");
                all += int.Parse(bit.Value.ToString()) * 5;
                total.Text = all.ToString();
            }
            else if (arr[0] == arr[1] && arr[0] == arr[2] && arr[0] == 1)
            {
                MessageBox.Show("中獎了!! 賺 " + (bit.Value *10).ToString() + " 元");
                all += int.Parse(bit.Value.ToString()) * 10;
                total.Text = all.ToString();
            }
            else if (arr[0] == arr[1] && arr[0] == arr[2] && arr[0] == 2)
            {
                MessageBox.Show("中獎了!! 賺 " + (bit.Value * 15).ToString() + " 元");
                all += int.Parse(bit.Value.ToString()) * 15;
                total.Text = all.ToString();
            }
            else if (arr[0] == arr[1] && arr[0] == arr[2] && arr[0] == 3)
            {
                MessageBox.Show("中獎了!! 賺 " + (bit.Value * 20).ToString() + " 元");
                all += int.Parse(bit.Value.ToString()) * 20;
                total.Text = all.ToString();
            }
        }
    }
}
