using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH10_test
{
    public partial class Form1 : Form
    {
        Button btn1;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // 顯示對話方塊，並判斷使用者是否按下對話方塊的 [確定] 鈕
            if (MessageBox.Show("請問是否離開遊戲嗎？", "Loading", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            id_Text.Text = "";
            psd_Text.Text = "";
            toolTip1.SetToolTip(id_Text, "請輸入帳號");
            toolTip2.SetToolTip(psd_Text, "請輸入密碼");
            ans.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = "goto101";
            int psd = 5168;
            string idtext = id_Text.Text;
            int psdtext = int.Parse(psd_Text.Text);
            if (idtext == id && psdtext == psd)
            {
                System.Diagnostics.Process.Start("http:\\google.com");
            }
            else
            {
                MessageBox.Show("帳號密碼輸入錯誤。");
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http:\\google.com");
        }

        private void star_Click(object sender, EventArgs e)
        {
            int n = int.Parse(n_Text.Text);
            float total = 0;
            float num =0;
            for(float i = 1; i <= n; i++)
            {
                num = (1/i);
                total += num;
            }

            ans.Text = "總和 : "+ total;
        }
    }
}
