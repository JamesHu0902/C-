using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolymorphism3
{

    // 使用介面
    interface ITarffic
    {
        int miles{get; set;}
        void MySpeedUP(int n);
    }
    // 定義Car車子類別繼承自交通工具類別
    class Car : ITarffic
    {
        static int x = 0;
        void ITarffic._miles(int n)
        {
            return x += n;
        }
        void ITarffic.MySpeedUP(int n)  // 覆寫父類別的SpeedUp方法
        {
            x = _miles(n);
            Console.WriteLine("\n 駕駛車子, 加速中, 前進 {0} 公里 .", x);
            Console.WriteLine("--------------------------------------");
        }
    }
    // 定義Airplane飛機類別繼承自交通工具類別
    class Airplane : ITarffic
    {

        void ITarffic._miles(int n)
        {
            return Car.x += n;
        }
        void ITarffic.MySpeedUP(int n)   // 覆寫父類別的SpeedUp方法
        {
            x = _miles(n);
            Console.WriteLine("\n駕駛飛機, 加速中, 前進 {0} 公里 .", Car.x);
            Console.WriteLine("--------------------------------------");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Car myCar = new Car();
            Airplane myAirplane = new Airplane();
            int input;
            while (true)
            {
                Console.Write("請問要駕駛->1.車子  2.飛機  其他.離開：");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    myCar.MySpeedUP(15);     //開車子,r參考指向myCar物件實體
                }
                else if (input == 2)
                {
                    myAirplane.MySpeedUP(150); //開飛機,r參考指向myAirplane物件實體
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
}
