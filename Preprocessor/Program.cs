#define DEBUG // 定義為 Debug 模式
#undef DEBUG // 解除定義
#define TRACE

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
    /// </summary>
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
            #if (DEBUG)
                Console.WriteLine("Debuging is enabled.");
            #elif (TRACE)
                Console.WriteLine("Tracing is enabled.");
            #else
                Console.WriteLine("Debuging is not enabled.");
            #endif
        }
    }
}
