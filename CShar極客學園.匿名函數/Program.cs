using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShar極客學園.匿名函數
{
    class Program
    {
        delegate void TestDelegate(string s);

        static void M(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            TestDelegate testDelA = new TestDelegate(M);
            testDelA("Hello, this is a delegate");

            // C# 2.0 Anonymous Method

            TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };
            testDelB("Hello, this is a Anonymous Method");

            // C# 3.0 Lambda Expression

            TestDelegate testDelC = (s) => { Console.WriteLine(s); };
            testDelB("Hello, this is a Lambda Expression");

        }
    }
}
