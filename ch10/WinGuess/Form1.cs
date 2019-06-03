using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 共用成員變數
        //guess用來存放電腦產生的亂數；
        //count存放猜數字的次數；
        //min為目前猜數字的最小值；
        //max為目前猜數字的最大值        
        int guess, count, min, max;
      
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 100);
            min = 1;
            max = 100;
            count = 0;
            lblTitle.Text = min + " < ? < " + max;
            lblMsg.Text = "共猜了 " + count + " 次";
            btnOk.Enabled = true;
            txtGuess.Text = "";
        }
        // 按 <確定> 鈕 執行     
        private void btnOk_Click(object sender, EventArgs e)
        {
            int myguess = 0;
            try
            {
                myguess = int.Parse(txtGuess.Text);
                count += 1;
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
         
            if (myguess >= 1 && myguess < 100)
            {
                if (myguess == guess)
                {
                    MessageBox.Show("賓果");
                    btnOk.Enabled = false;
                }
                else if (myguess > guess)
                {
                    max = myguess;
                    MessageBox.Show("再小一點");
                }
                else if (myguess < guess)
                {
                    min = myguess;
                    MessageBox.Show("再大一點");
                }
            }
            else
            {
                MessageBox.Show("輸入提示範圍內的數字");
            }
            txtGuess.Text = "";
            lblMsg.Text = "共猜了 " + count + " 次";
            lblTitle.Text = min + " < ? < " + max;
        }
        // 按 <重玩> 鈕 執行此事件
        private void btnAgain_Click(object sender, EventArgs e)
        {
              Form1_Load(sender, e);  // 執行 Form1_Load() 事件函式
        }
        // 按 <結束> 鈕 執行此事件
        private void btnEnd_Click(object sender, EventArgs e)
        {
            // 顯示對話方塊，並判斷使用者是否按下對話方塊的 [確定] 鈕
            if (MessageBox.Show("請問是否離開遊戲嗎？", "猜數字遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

     }
}
