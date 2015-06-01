#define DEBUG
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.Attribute
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Message("In Main Function");
            Function1();
        }

        [Obsolete("Don't use old Method!",false)] // 宣告方法已經過時，不建議使用（true：會有 error 訊息）
        static void Function1()
        {
            MyClass.Message("In Function1");
            Function2();
        }
        static void Function2()
        {
            MyClass.Message("In Function2");
        }
    }

    public class MyClass
    {
        // 條件 DEBUG模式下，才會啟用

        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple=false, Inherited=false)]
    public class HelpAttribute : Attribute
    {
        protected string description { get; private set; }
        public string Name { get; set; }
        public HelpAttribute(string descripton_in)
        {
            this.description = descripton_in;
        }
    }

    // value, type, System.Type, object, enum
    [HelpAttribute("This is a do-nothing class",Name="極客學院")]
    public class AnyClass
    {
        
    }
}
