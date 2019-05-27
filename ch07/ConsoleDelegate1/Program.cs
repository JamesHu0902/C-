using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate1
{

    delegate bool CompareFunc(int X, int Y);

    class Program
    {
        // IsSmaller()自定函式
        static bool IsSmaller(int X, int Y)
        {
            return X < Y;
        }
        // IsBigger()自定函式
        static bool IsBigger(int X, int Y)
        {
            return X > Y;
        }
        // MySort()自定函式
        static void MySort(int[] obj, CompareFunc CompareMethod)
        {
            for (int i = 0; i <= obj.Length - 2; i++)
            {
                for (int j = i + 1; j <= obj.Length - 1; j++)
                {
                    if (CompareMethod(obj[j], obj[i]))
                    {
                           int tmp = obj[j];
                           obj[j] = obj[i];
                           obj[i] = tmp;
                    }
                }
            }
        }
        // Show()自定函式
        static void Show(int[] obj)
        {
              for (int i = 0; i <= obj.Length - 1; i++)
              {
                     Console.Write("{0}, ", obj[i]);
              }
              Console.WriteLine();
        }
        // 主程式 Mail()
        static void Main(string[] args)
        {
              int[] IntArray = { 34, 21, 54, 32, 12 };
              CompareFunc CompareIt;
              CompareIt = new CompareFunc(IsSmaller);

              Console.Write("\n由小排到大 : \n");
              MySort(IntArray, CompareIt);
              Show(IntArray);
              Console.WriteLine();
              Console.Write("\n由大排到小 : \n");
              MySort(IntArray, new CompareFunc(IsBigger));
              Show(IntArray);

              Console.Read();
        }
    }
}
