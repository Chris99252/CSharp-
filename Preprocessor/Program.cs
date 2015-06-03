#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學院.Preprocessor
{
    /// <summary>
    /// 預處理程序：在實際編譯前就預先處理一些資料
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
        }
    }
}
