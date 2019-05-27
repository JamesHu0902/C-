using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTextBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] address = new string[]{"台北市南港路三段52號7樓7F",
                                     "台北市南港路二段12號7樓7F",
                                     "台北市忠孝東路一段12號" };
            AutoCompleteStringCollection myAdd =
                                    new AutoCompleteStringCollection();
            myAdd.AddRange(address);
            txtAdd.AutoCompleteCustomSource = myAdd;
            txtAdd.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAdd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPage.AutoCompleteSource = AutoCompleteSource.HistoryList;
        }
        // 按下 [確定] 時執行
        private void OK_Click(object sender, EventArgs e)
        {
            // 在對話方塊上顯示使用者輸入的公司, 住址, 網站資訊
            MessageBox.Show("公司：" + txtCompany.Text + "\n住址：" +
                         txtAdd.Text + "\n網站：" + txtPage.Text);
        }
    }
}
