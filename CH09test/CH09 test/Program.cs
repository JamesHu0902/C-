using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;  // 引用System.IO命名空間
namespace CH09_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, fname1,fname2;
            //宣告StreamReader的sr物件, 用來讀出資料
            StreamReader sr;
            //宣告StreamWriter的sw物件, 用來寫入資料
            StreamWriter sw;
            string f1;
            string f2;
            // 開新檔案
            FileInfo newfile = new FileInfo("C:\\Users\\Owner\\source\\C#\\CH09test\finally.txt");
            sw = newfile.CreateText();
            Console.Write("1. 請輸入要讀寫的檔案路徑->");
            fname1 = Console.ReadLine();
            try
            {
                f1 = new FileInfo(fname1);
                temp = f1.OpenText();
                sw = newfile.CopyTo(temp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("檔案路徑有錯");
                Console.WriteLine();
            }
            
            Console.Write("2. 請輸入要讀寫的檔案路徑->");
            fname2 = Console.ReadLine();
            try
            {
                f2 = new FileInfo(fname2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("檔案路徑有錯");
                Console.WriteLine();
            }

            
        }
    }
}
