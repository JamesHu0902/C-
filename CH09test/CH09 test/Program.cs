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
            FileInfo f1;
            FileInfo f2;
            // 開新檔案
            FileInfo newfile = new FileInfo("C:\\Users\\cinphown\\source\\cs2015_CD\\CH09test\\new.txt");
            
            Console.Write("1. 請輸入要讀寫的檔案路徑->");
            fname1 = Console.ReadLine();
            try
            {
                //宣告StreamReader的sr物件, 用來讀出資料
                StreamReader sr = new StreamReader(fname1);
                temp = sr.ReadToEnd();
                Console.WriteLine(temp);
                                
                //宣告StreamWriter的sw物件, 用來寫入資料
               
                StreamWriter sw = newfile.AppendText();///newfile.appendtext();
                sw.Write(temp);
                sw.Flush();
                sw.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("檔案路徑有錯");
                Console.WriteLine();
            }

            // 第二則
            Console.Write("2. 請輸入要讀寫的檔案路徑->");
            fname2 = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader(fname2);
                temp = sr.ReadToEnd();
                Console.WriteLine(temp);
                StreamWriter sw = newfile.AppendText();///newfile.appendtext();
                sw.Write(temp);
                sw.Flush();
                sw.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine("檔案路徑有錯");
                Console.WriteLine();
            }
            Console.WriteLine("==================");
            Console.WriteLine("複製成功");
            Console.Read();
        }
    }
}
