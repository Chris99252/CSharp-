using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學院.ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoLinq();

            StringCount();
        }

        private static void DemoLinq()
        {
            int[] numbers = { 10, 45, 15, 39, 21, 36 };

            // 使用 System.Linq 內的 （擴充方法） OrderBy，也叫語法糖。

            var result = numbers.OrderBy(n => n);

            foreach (var item in result)
            {
                Console.WriteLine("{0} ", item);
            }
        }

        private static void StringCount()
        {
            string s = "This is jikexueyuan C# tutorial";

            int i = s.WordCount();

            Console.WriteLine("Word count of s is {0}", i);
        }
    }

    // 擴充方法：靜態的類別，靜態的方法，參數對於哪一個類型進行擴充

    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
