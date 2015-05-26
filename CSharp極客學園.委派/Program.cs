using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.委派
{
    // 委派宣告端

    delegate int NumberChange(int n);
    class Program
    {
        /// <summary>
        /// 委派 Delegate
        /// </summary>
        /// <param name="args"></param>

        static int num = 10;

        static void Main(string[] args)
        {
            // System.Delegate delegate

            //呼叫端

            NumberChange nc1 = new NumberChange(AddNum);
            nc1(25);
            Console.WriteLine("Value of num : {0}",num);
        }

        // 邏輯端

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
    }
}
