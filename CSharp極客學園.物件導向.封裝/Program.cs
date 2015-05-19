using CSharp極客學園.物件導向.封裝.Another;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnotherAssembly;

namespace CSharp極客學園.物件導向.封裝
{
    class Program
    {
        /// <summary>
        /// 封裝，並透過存取修飾詞，來控制它的權限
        /// public, private, internal, protected, internal protected
        /// internal：在 Assembly 程序集內可叫用，『方案右鍵』 -> 『屬性』
        /// C# 輸出有兩種 .exe 可執行文件, .dll library庫文件 -> 都屬於 Assembly
        /// assembly 與 namespace：可引用多個命名空間
        /// protected：本身的 class 或繼承於它的 class 可叫用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // public, private, internal, protected, internal protected

            Person p = new Person();
            p.Age = 18;
            Console.WriteLine(p.Age);
            Console.WriteLine(p.GetAge());

            // namespace：using CSharp極客學園.物件導向.封裝.Another;

            AnotherNamespaceClass an = new AnotherNamespaceClass();

            Console.WriteLine(an.internalString);   

            // Assembly 『方案總管』-> 『參考』 -> 右鍵『加入參考』 -> 專案 -> 勾選 AnotherAssembly。

            // using AnotherAssembly;

            Class1 c1 = new Class1();

            // protected

            Man m = new Man();

            Console.WriteLine(m.GetPersonName());

        }
        class Person
        {
            public int Age { get; set; }

            protected string name = "PersonName";

            private string PassWord { get; set; } // 外部不能使用，只在內部使用

            public int GetAge()
            {
                if (CheckAge())
                {
                    return this.Age;
                }
                else
                {
                    return -1;
                }
            }

            private bool CheckAge()
            {
                if (this.Age <= 0)
	            {
                    return false;
	            }
                else
                {
                    return true;
                }
            }
        }

        class Man : Person
        {
            public string GetPersonName()
            {
                return base.name;
            }
        }
    }
}
