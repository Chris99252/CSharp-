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
        delegate int TestDelegate2(int i);
        delegate TResult Func<T, TResult>(T arg0);

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

            StartThead();

            lambda();

        }

        private static void StartThead()
        {
            System.Threading.Thread t1 = new System.Threading.Thread(
                delegate() // 不可使用 ref out is 修飾參數 
                {
                    Console.WriteLine("Hello World!");
                }
            );
            t1.Start();
        }

        private static void lambda()
        {
            // () => expression
            TestDelegate2 lambdaDel = (x) => x * x;
            Console.WriteLine(lambdaDel(5)); // 25

            Func<int, bool> myFunc = (x) => x == 5;
            Console.WriteLine(myFunc(4)); // false
        }
    }
}
