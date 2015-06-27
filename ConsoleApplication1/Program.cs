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
            int[] numbers = { 10, 45, 15, 39, 21, 36 };

            // 使用 System.Linq 內的 （擴充方法） OrderBy，也叫語法糖。

            var result = numbers.OrderBy(n => n);

            foreach (var item in result)
            {
                Console.WriteLine("{0} ", item);
            }
        }
    }
}
