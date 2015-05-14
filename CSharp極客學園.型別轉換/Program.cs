using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.型別轉換
{
    /// <summary>
    /// C# 是強型別的語言，在編譯的時候就會進行型別的檢查，避免在運行的時候出錯
    /// 類型轉換：隱式轉換(自動轉換)（向上轉換） 與 顯式轉換（強制轉換）（向下轉換）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 隱式轉換，小的轉大的，可以自動轉換

            int i = 10;
            long l = i;
            C1 c1 = new C2(); // 隱式轉換，向上轉型

            // 顯式轉換，大的轉小的，必須強制轉換

            double d = 10.05;
            int iFormD = (int)d;
            Console.WriteLine(iFormD); // 輸出 10，資料會有缺失的風險
            C1 c11 = new C1();
            try
            {
                C2 c2 = (C2)c11; // 顯式轉換，向下轉換，執行可能會出現例外錯誤
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // throw e;
            }

            // 透過 is 判斷型別

            Console.WriteLine(c11 is C1); // 輸出 True
            Console.WriteLine(c11 is C2); // 輸出 False

            // 利用as，安全的方式進行轉換

            C2 c22 = c11 as C2; // 可運行不會出錯，c11在轉換的過程中發現不能轉為 C2 型別，會丟回一個 null 值

            Console.WriteLine(c22 == null); // 輸出 True

            // int iAS = 5 as int; // as 只能用於參考型別，因為實值型別，不能給予 null 值。
        }
    }

    class C1
    {

    }

    class C2 : C1
    {

    }
}
