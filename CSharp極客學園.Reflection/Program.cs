using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Type

            string s = "Hello Reflection";
            Type t1 = s.GetType();
            Console.WriteLine(t1.FullName); // 輸出：System.String
            
            Type t2 = Type.GetType("System.String", false,true); // 變數 ｜ 是否報錯｜ 忽略大小寫
            Console.WriteLine(t2.FullName); // 輸出：System.String
            
            Type t3 = typeof(string);
            Console.WriteLine(t3.FullName); // 輸出：System.String

            //GetMethods(t1);

            Console.WriteLine("Copy method: {0}", t3.GetMethod("Copy"));

            GetMethods(t1, BindingFlags.Public | BindingFlags.Instance);

            // GetFields(), GetProperites()

        }
        public static void GetMethods(Type t, BindingFlags f)
        {
            MethodInfo[] mi = t.GetMethods(f);

            foreach (var item in mi)
            {
                Console.WriteLine(item.Name);
            }
        } 
    }
}
