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

            // 呼叫端 - 靜態方法

            NumberChange nc1 = new NumberChange(AddNum);
            nc1(25);
            Console.WriteLine("Value of num : {0}",num); // 輸出：35

            // 呼叫端 - 外部方法

            MyClass mc = new MyClass();

            NumberChange nc2 = new NumberChange(mc.AddNum);
            nc2(35);
            Console.WriteLine("Value of num : {0}", mc.num); // 輸出：45

            // 呼叫端 - 同一個委派，使用不同的方法，多型

            NumberChange nc3 = new NumberChange(mc.MutliNum);
            nc3(2);
            Console.WriteLine("Value of num : {0}", mc.num); // 輸出：90

        }

        // 邏輯端

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
    }

    class MyClass
    {
        public int num = 10;

        public int AddNum(int p)
        {
            num += p;
            return num;
        }
        public int MutliNum(int p)
        {
            num *= p;
            return num;
        }
    }
}
