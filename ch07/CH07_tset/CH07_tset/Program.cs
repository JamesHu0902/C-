using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_tset
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Airplane myAirplane = new Airplane();
            ITarffic car = (ITarffic)myCar;
            int input;
            while (true)
            {
                Console.Write("請問要駕駛->1.車子  2.飛機  其他.離開：");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                        myCar.MySpeedUP(60);     //開車子,r參考指向myCar物件實體
                        car.MySpeedUP(10);
                }
                else if (input == 2)
                {
                        myAirplane.MySpeedUP(180); //開飛機,r參考指向myAirplane物件實體
                }
                else
                {
                        break;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }

    // 使用介面
    interface ITarffic
    {
       

        void MySpeedUP(int n);
    }
    class Totle
    {
        public static int miles{get;set;}
    }
    class Car : Totle,ITarffic 
    {
       
        public void MySpeedUP(int n)  // 覆寫介面的SpeedUp方法
        {
            miles += n; // 使用類別靜態變數
            Console.WriteLine("\n 駕駛車子, 加速中, 前進 {0} 公里 .", miles);
            Console.WriteLine("--------------------------------------");
        }
    }

    class Airplane : Totle,ITarffic 
    {
        
        public void MySpeedUP(int n)  // 覆寫介面的SpeedUp方法
        {
            miles += n; 
            Console.WriteLine("\n 駕駛飛機, 加速中, 前進 {0} 公里 .", miles);
            Console.WriteLine("--------------------------------------");
        }
    }

}
