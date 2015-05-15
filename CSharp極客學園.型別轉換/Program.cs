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
    /// 透過內建提供的Method方法：ToString(), Convert.ToInt32, Int32.Parse, Int32.TryParse
    /// boxing 裝箱：把一個實值型別，轉為參考型別
    /// unboxing 拆箱：把一個參考型別，轉為實值型別
    /// boxing 與 unboxing，都在記憶體上做搬移，很耗費資源，盡可能避免
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
            Console.WriteLine(iFormD); // 輸出 10，資料會有缺失的風險，以及例外錯誤
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

            // 利用 as，安全的方式進行轉換

            C2 c22 = c11 as C2; // 可運行不會出錯，c11在轉換的過程中發現不能轉為 C2 型別，會丟回一個 null 值

            Console.WriteLine(c22 == null); // 輸出 True

            // int iAS = 5 as int; // as 只能用於參考型別，因為實值型別，不能給予 null 值。

            string sFromi = i.ToString(); // ToString() 轉換成字串

            int iFromS = Convert.ToInt32("100"); // Convert 轉換型別

            //int iFromS2 = Convert.ToInt32("CSharp"); // 錯誤：輸入字串格式不正確。

            int iFromS3 = Int32.Parse("101"); // Parse 轉換型別

            //int iFromS4 = Int32.Parse("CSharp"); // 錯誤：輸入字串格式不正確。

            int iFromS5;

            bool succeed = Int32.TryParse("102", out iFromS5); // TryParse 試著去轉換

            Console.WriteLine(succeed +" : "+iFromS5); // 輸出 True : 102，轉換成功

            bool succeed2 = Int32.TryParse("CSharp", out iFromS5); 

            Console.WriteLine(succeed2 + " : " + iFromS5); // 輸出 False : 0，轉換失敗，輸出整數的空值 0

            // 實作自己的轉換，透過 IConvertible, TypeConverter

            int iToBoxing = 100;

            object iBoxed = iToBoxing; // boxing 隱式轉換，因為所有的型別都是繼承 System.object，向上轉換

            int iUnBoxing = (int)iBoxed; // unBoxing 顯式轉換，由父類別轉為子類別，向下轉型

            object nullObject = null;

            // int iNull = (int)nullObject; // 錯誤：NullReferenceException。

            int? iNullable = null; // 宣告一個可為 null 值的 int

            System.Nullable<int> iNullable2 = 100; // 等同於 int?

            Console.WriteLine(iNullable2.Value); // 輸出 100

            // Console.WriteLine(iNullable.Value); // 錯誤：可為 Null 的物件必須具有值

            Console.WriteLine(iNullable.HasValue); // 輸出：false，可以預先判斷

            Console.WriteLine(iNullable.GetValueOrDefault()); // 輸出：0，若為空值，給予預設的 null 值

            Console.WriteLine(iNullable2.GetValueOrDefault()); // 輸出：100

            int i2 = iNullable ?? 500; // 若 ?? 前的變數值為 null，那就給予 ?? 後面的值

            Console.WriteLine(i2); // 輸出：500

            int i3 = iNullable2 ?? 500; // 若 ?? 前的變數值為 null，那就給予 ?? 後面的值

            Console.WriteLine(i3); // 輸出 100


        }
    }

    class C1
    {

    }

    class C2 : C1
    {

    }
}
