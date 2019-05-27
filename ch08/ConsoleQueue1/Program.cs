﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;  // 匯入System.Collections命名空間

namespace ConsoleQueue1
{
    class Program
    {
           class Member
            {
                  public string Name { get; set; }      // 姓名屬性          
                  public bool Select { get; set; }      // 選課屬性
                  public int Score { get; set; }        // 成績屬性

                  public override string ToString()    // 覆寫覆類別 ToString()方法
                  {
                       return string.Format("姓名 : {0} \t 選課 :{1} \t 成績: {2} \n ", Name, Select ? "是" : "否", Score.ToString());
                   }
            }
           static void Main(string[] args)
           {
                 Queue m = new Queue();   // 非泛型           

                 m.Enqueue(new Member() { Name = "David", Select = true, Score = 70 });
                 m.Enqueue(new Member() { Name = "Mary", Select = false, Score = 65 });
                 m.Enqueue(new Member() { Name = "Tom", Select = true, Score = 85 });
                 m.Enqueue(new Member() { Name = "Jack", Select = true, Score = 95 });

                 Console.WriteLine("=== 非泛型 Queue 操作 需強制轉換 .... \n");
                 while (m.Count > 0)
                 {
                       Console.WriteLine("{0} ", ((Member)m.Dequeue()).ToString());
                 }
                 Console.Read();
            }
    }
}