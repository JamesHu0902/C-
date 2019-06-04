using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH11test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 斜體_CheckedChanged(object sender, EventArgs e)
        {
            chengtext.Font = new Font(chengtext.Font, FontStyle.Italic); 
        }

        private void 粗體_CheckedChanged(object sender, EventArgs e)
        {
            chengtext.Font = new Font(chengtext.Font, FontStyle.Bold);
        }

        private void 正常_CheckedChanged(object sender, EventArgs e)
        {
            chengtext.Font = new Font(chengtext.Font, FontStyle.Regular);
        }

        private void 底線_CheckedChanged(object sender, EventArgs e)
        {
            chengtext.Font = new Font(chengtext.Font, FontStyle.Underline);
        }

        private void cbofont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chengtext.Font = new Font(chengtext.Font, FontFamily.);

            chengtext.Text = cbofont.Text;
            string f = cbofont.Text;
            FontStyle style = chengtext.Font.Style;
            chengtext.Font = new Font(f, 26, style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbofont.Text = "微軟正黑體";

            //var aa= FontStyle.Bold | FontStyle.Italic;
            chengtext.Font = new Font("Arial", 26, FontStyle.Bold|FontStyle.Italic);            
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = listBox1.Text;
            if (c == "黑色")
            {
                chengtext.ForeColor = Color.Black;
            }
            else if(c == "紅色")
            {
                chengtext.ForeColor = Color.Red;
            }
            else if(c == "黃色")
            {
                chengtext.ForeColor = Color.Yellow;
            }
            else if(c == "藍色")
            {
                chengtext.ForeColor = Color.Blue;
            }
            else if(c == "綠色")
            {
                chengtext.ForeColor = Color.Green;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clb;
            var aa= FontStyle.Regular;
            //FontStyle fsa;
            //FontStyle.Bold | FontStyle.Italic | FontStyle.Underline
            for (int i=0 ; i < checkedListBox1.Items.Count; i++)
            {
                
                if (checkedListBox1.GetItemChecked(i))
                {
                    clb = checkedListBox1.Items[i].ToString();
                    if(clb == "粗體")
                    {
                        aa = FontStyle.Bold | aa;
                        //fsa = FontStyle.Bold;
                    }
                    if (clb == "斜體")
                    {
                        aa = FontStyle.Italic | aa;
                    }
                    if (clb == "底線")
                    {
                        aa = FontStyle.Underline | aa;
                    }
                }
            }
            
            FontFamily f = new FontFamily(chengtext.Font.Name);
            //chengtext.Text = fs;
            //fsa = fs;
            chengtext.Font = new Font(f, 26, aa);
        }
    }
}
