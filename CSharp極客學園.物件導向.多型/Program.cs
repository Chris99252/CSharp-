using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.物件導向.多型
{
    class Program
    {
        /// <summary>
        /// 多型：一個型態能夠執行多個功能。
        /// 1. 靜態多型：編譯時就實現多型
        /// 2. 動態多型：運行時才實現多型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PrintHello(); // 會有語法提示，可以使用的多型

            PrintHello("word");

            PrintHello(10);

            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.Number = 2;
            c2.Number = 3;
            Console.WriteLine((c1 + c2).Number); // 輸出：5。c1.Number + c2.Number
        }
        
        // 靜態多型： 達成方法的 overload

        public static void PrintHello() 
        {
            Console.WriteLine("Hello");
        }
         
        public static void PrintHello(string toWho)// 透過參數的個數不同，達成方法的多型
        {
            Console.WriteLine("Hello string {0}", toWho);
        }

        public static void PrintHello(int times)// 透過參數的型別不同，達成方法的多型
        {
            Console.WriteLine("Hello int {0}", times);
        }
        //public static string PrintHello()// 回傳值不同，無法達成方法的多型，因為已定義了一個具有相同參數型別的方法
        //{
        //    return "Hello 回傳值不同";
        //}
    }
    class Complex
    {
        public int Number { get; set; }

        // 公開靜態的方法，operator + 加法運算子，達成加法的多型

        public static Complex operator + (Complex c1,Complex c2)
        {
            Complex c = new Complex();
            c.Number = c1.Number + c2.Number;
            return c;
        }
    }
}
