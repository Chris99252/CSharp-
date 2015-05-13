using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園_參考型別
{
    class Program
    {
        /// <summary>
        /// 預定型別 object, string, dynamic
        /// System.Object, System.String, System.Dynamic
        /// 編譯階段（大部分的類型檢查），運行階段（Dynamic的類別檢查）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // System.Object (最基本的型別)

            object o = new object(); // 等價關係
            object o2 = new Object();
            object o3 = new System.Object();

            Console.WriteLine(o.GetType()); // 輸出 System.Object
            Console.WriteLine(o.ToString()); // 輸出 System.Object
            
            int i = 5;
            Console.WriteLine(i.ToString()); // 輸出 5

            // System.String 

            string s = "CSharp極客學園"; // 宣告時，長度已經固定
            string s2 = "CSharp";
            s2 += "極客學園";
            Console.WriteLine(s); // 輸出 CSharp極客學園
            Console.WriteLine(s2); // 輸出 CSharp極客學園
            
            Console.WriteLine(s == s2); // 輸出 True 值相等
            Console.WriteLine((object)s == (object)s2); // 輸出 False 位址不相等，強制轉換
            
            char c = s[2]; // 取得單一字符
            Console.WriteLine(c); // 輸出 h

            string u = "\\\u0066\n";
            Console.WriteLine(u); // [ \\ -> \ ], [ \u0066 -> f ], [ \n -> enter ]

            string at = @"C\CSharp極客學園\Program.cs";
            Console.WriteLine(at); // 輸出 C\CSharp極客學園\Program.cs
            string noAt = "C\\CSharp極客學園\\Program.cs";
            Console.WriteLine(noAt); // 輸出 C\CSharp極客學園\Program.cs

            Console.WriteLine(at.Contains("極客")); // 是否包含，輸出 True
            Console.WriteLine(at.Length); // 字串長度，輸出 23 
            Console.WriteLine(at.IndexOf("極")); //字符首次在字串出現的位置，輸出 8

            // 因 string 在宣告時就給予固定的長度
            // 若需要對 string 新增或修改字串長度，需要重新配置記憶體的內存空間，耗資源
            // 可以改用 StringBuilder

            StringBuilder builder = new StringBuilder(); // 宣告時，長度不固定
            builder.Append("CSharp");
            builder.Append("極客學園");
            Console.WriteLine(builder); // 輸出 CSharp極客學園
            builder.AppendFormat(" hello{0} {1}", "極客學園", "CSharp"); // 輸出 CSharp極客學園 hello極客學園 CSharp
            Console.WriteLine(builder);
        }
    }
}
