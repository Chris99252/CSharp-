#define DEBUG // 定義為 Debug 模式
//t#undef DEBUG // 解除定義
//#define TRACE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學院.Preprocessor
{
    /// <summary>
    /// 預處理程序：在實際編譯前就預先處理一些資料
    /// #region, #define, #undef, #if, #elif, #else, #endif
    /// #warning 拋出警告 #error 拋出異常
    /// #line 行數 文件名稱
    /// </summary>
    
#pragma warning disable 414, 3021
    [CLSCompliant(false)]
    class Program
    {
        static void Main(string[] args)
        {
            #region Hello 極客學院：可折疊代碼
            // Hello
            var s = "Hello 極客學院";
            Console.WriteLine(s);
            #endregion

            // 只有在 Debug 模式下才執行此段代碼
            #if DEBUG
                Console.WriteLine("Debuging is enabled.");
            #line 200 "Sepcial"
            #warning DEBUG is defined (warning)
            #elif TRACE
                Console.WriteLine("Tracing is enabled.");
            #else
                Console.WriteLine("Debuging is not enabled.");
            #endif
            #line default
            // #error I'm not happy! (error)
        }
    }

#pragma warning restore 3021
    [CLSCompliant(false)]
    public class MyClass
    {
        int i = 1;

        public static void M()
        {
// #pragma checksum "filename" "{guid}" "check bytes"
        }
    }
}
