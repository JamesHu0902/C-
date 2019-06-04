using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH11test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo.Text = cbo.Items[0].ToString();
        }
        public class Roo
        {
            public string[] data { get; set; }
            public Roo(String operation)
            {
                switch (operation)
                {
                    case "動作":
                        data = new string[4] { "葉問1", "葉問2", "一刀傾城", "角頭" };
                        break;
                    case "布袋戲":
                        data= new string[2] { "倉璇氣", "霹靂神州" };
                        break;
                    default:
                        data = new string[5] { "蠟筆小新", "刀劍神諭", "海賊王", "火影忍者", "一拳超人" };
                        break;
                }
            }
            
        }
    
        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<string> arr = new List<string>();
            clb.Items.Clear();

            //string[] act = new string[4] {"葉問1","葉問2","一刀傾城","角頭" };
            //string[] b = new string[2] {"倉璇氣","霹靂神州"};
            //string[] c = new string[5] {"蠟筆小新","刀劍神諭","海賊王","火影忍者","一拳超人" };
            clb.Items.AddRange (new Roo(cbo.Text).data);
            //string select = cbo.Text;
            //if(select=="動作")
            //    arr = act.ToList();
            //else if(select =="布袋戲")
            //    arr = b.ToList();
            //else
            //    arr = c.ToList();

            //foreach (string Name in 動作)
            //{
            //    arr.Add(Name.ToString());
            //}

            //for (int i=0;i<arr.LongCount();i++)
            //{
            //    clb.Items.Add(arr[i].ToString());
            //}
        }
    }
}
