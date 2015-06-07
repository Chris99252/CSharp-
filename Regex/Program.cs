using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShar極客學園.Regualr
{
    /// <summary>
    /// 擴充功能與更新
    /// </summary>

    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string pattern = "abc";
            Console.WriteLine(Regex.IsMatch(s1,pattern)); // 輸出：true
        }
    }
}
