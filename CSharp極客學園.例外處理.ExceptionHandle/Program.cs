using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.異常處理.ExceptionHandle
{
    /// <summary>
    /// ExceptionHandle：異常處理，避免程式立即 crash
    /// Exception Class：Message 異常錯誤訊息。StackTrace：呼叫堆疊，可以追蹤是在那個流程點出錯。TargetSite：那個 Method 導致出錯。
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
            catch (NullReferenceException e) // System.Exception
            {
                Console.WriteLine(e.Message);
            } 
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message); // 正常執行，輸出：嘗試以零除
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally // 不管 catch 異常與否，最後都要執行 finally
            {
                Console.WriteLine("Anyway, we arrive here!");
            }

            Console.WriteLine("After try caych");

            // throw new NullReferenceException(); // 空引用異常

            var ae = new ArgumentException(); // 所有參數異常
            var aen = new ArgumentNullException(); // 具體參數異常，為空值異常
            var aore = new ArgumentOutOfRangeException(); // 具體參數異常，超過範圍異常
            var dne = new DirectoryNotFoundException(); // System.IO，文件路徑沒有找到異常
            var fne = new FileNotFoundException(); // 文件沒有找到異常
            var ioe = new InvalidOperationException(); // 運算異常
            var nie = new NotImplementedException(); // 未實現異常

            if (true)
            {
                // logic
            }

            try
            {

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
