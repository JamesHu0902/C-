using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH09test3
{
    class Product
    {
        int Id,_Price;
        string Pname;
        public Product(string name,int id) //  Product類別的建構式，用來設定產品名稱、編號
        {
            Pname = name;
            Id = id;
        }
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value <= 0)
                {
                    //Console.WriteLine("產品 {0} 售價設置失敗! 原因:不能小於等於0", Pname, value);
                    // 產生 SalaryException 例外類別物件
                    throw new ProductException(Pname);
                    //_Price = 1;
                }
                else
                {
                    _Price = value;
                }
            }
        }
        public void show()
        {
            Console.WriteLine("編號 {0} 產品名稱 {1} 價錢設置為 : {2}", Id, Pname, _Price);
        }
    }

    // 定義 ProductException 例外繼承自 Exception 例外類別
    class ProductException : Exception
    {
        string Pname;
        public ProductException(string name) //  Product類別的建構式，用來設定產品名稱、編號
        {
            Pname = name;
        }
        public override String ToString()  // 覆寫ToString()方法
        {
            return "發生 ProductException 例外類別";
        }
        // 覆寫 Message 屬性, 該屬性是唯讀屬性
        public override String Message
        {
            get
            {
                return "售價設置失敗! 原因:不能小於等於 0";
            }
        }
        public void ShowMsg()    // 新增  ShowMsg() 方法
        {
            Console.WriteLine("請勿隨意輸入!!");
        }
        public void ShowSourceEx()
        {
            Console.WriteLine("發生例外來源 : {0}", Pname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product PS4 = new Product("PS4", 0001);
                PS4.Price = 50000;
                PS4.show();
                Console.WriteLine("=================================");
                Product XBOX = new Product("XBOX", 0002);
                // 設定Peter物件的薪水為負數，因此會產生SalaryException例外類別
                XBOX.Price = -10000;
                XBOX.show();
            }
            catch (ProductException ex)  // 補捉 SalaryException 例外
            {
                // 呼叫 SalaryException 的 ToString() 方法
                Console.WriteLine(ex.ToString());
                // 呼叫 SalaryException 的 Message 屬性
                Console.WriteLine(ex.Message);
                // 呼叫 SalaryException 的ShowMsg()方法
                ex.ShowMsg();
                // 第四題 新增方法 顯示來源物件
                ex.ShowSourceEx();
                //ex.ShowSourceEx(ex.Source);
            }


            Console.Read();
        }
    }
}
