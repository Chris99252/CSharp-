using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.多重委派
{
    /// <summary>
    /// Multi-casting delegate
    /// 可以新增減少，依照順序執行
    /// </summary>

    delegate void D(int x);

    class Program
    {
        static void Main(string[] args)
        {
            D cd1 = new D(MyClass.Method1);
            cd1(-1); // 輸出：MyClass.Method1：-1
            Console.WriteLine();
            
            D cd2 = new D(MyClass.Method2);
            cd2(-2); // 輸出：MyClass.Method2：-2
            Console.WriteLine();

            D cd3 = cd1 + cd2;
            cd3(10); // 輸出：MyClass.Method1：10   MyClass.Method2：10
            Console.WriteLine();

            MyClass mc = new MyClass();

            D cd4 = new D(mc.Method3);
            cd3 += cd4;
            cd3(30); // 輸出：MyClass.Method1：30   MyClass.Method2：30  MyClass.Method3：30
            Console.WriteLine();

            cd3 += cd1;
            cd3(40); // 輸出：MyClass.Method1：40   MyClass.Method2：40  MyClass.Method3：40   MyClass.Method1：40
            Console.WriteLine();
            
            cd3 -= cd1;
            cd3(50); // 輸出：MyClass.Method1：50   MyClass.Method2：50  MyClass.Method3：50
            Console.WriteLine();

            cd3 -= cd4;
            cd3 -= cd2;
            cd3(60); // 輸出：MyClass.Method1：60
            
            cd3 -= cd1;
            cd3(70); // 例外異常：空值
        }
    }
    class MyClass
    {
        public static void Method1(int i)
        {
            Console.WriteLine("MyClass.Method1：{0}", i);
        }

        public static void Method2(int i)
        {
            Console.WriteLine("MyClass.Method2：{0}", i);
        }

        public void Method3(int i)
        {
            Console.WriteLine("MyClass.Method3：{0}", i);
        }
    }
}
