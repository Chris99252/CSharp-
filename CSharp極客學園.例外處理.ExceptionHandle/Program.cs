using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.異常處理.ExceptionHandle
{
    /// <summary>
    /// ExceptionHandle:異常處理，避免程式立即 crash
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            try
            {
                int y = 100 / x; // 異常訊息：嘗試以零除。
            }
            catch (Exception e) // System.Exception
            {
                Console.WriteLine(e.Message); // 正常執行，輸出：嘗試以零除
            } 
            finally // 不管 catch 異常與否，最後都要執行 finally
            {
                Console.WriteLine("Anyway, we arrive here!");
            }

            Console.WriteLine("After try caych");
            // throw new NullReferenceException(); // 空引用異常
        }
    }
}
