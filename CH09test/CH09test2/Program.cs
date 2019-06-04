using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH09test2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo newfile = new FileInfo("C:\\Users\\cinphown\\source\\cs2015_CD\\CH09test\\letto.txt");

            StreamWriter sw;
            //sw = newfile.AppendText();
            sw = newfile.CreateText();
            Random ran = new Random();
            int max;
            Console.WriteLine("請輸入要購買的張數 : ");
            max = int.Parse(Console.ReadLine());

            for(int j=1;j<=max;j++)
            {
                Console.Write("第 {0} 大熱透號碼如下 : " ,j);
                sw.Write("第 {0} 大熱透號碼如下 : ", j);
                for(int i = 0; i < 7; i++)
                {
                    int n = ran.Next(1, 50);
                    //arr.Add(n);
                    if(i == 6)
                    {
                        sw.Write(" 特別號碼 : {0}", n);
                        Console.Write(" 特別號碼 : {0}", n);
                    }
                    else
                    {
                        sw.Write(n + " \t");
                        Console.Write(n + " \t");
                    }
                }
                sw.Write("\n");
                Console.Write("\n");
            }

            sw.Flush();
            sw.Close();

            Console.Write("欲購買的 {0} 組樂透彩號碼寫入 {1} 內了...", max,newfile);
            Console.Read();
        }
    }
}
