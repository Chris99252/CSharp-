using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園_數值型別
{
    class Program
    {
     
        /// <summary>
        /// value 數值型別：基本型數值別,struct,enum
        /// reference 參考型別：object,string,delegate,class,interface
        /// pointer 指標型別，C#不太使用
        /// </summary>
        /// <param name="args"></param>

        // enum 列舉類型，限定值的可能性

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Days2
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Days3 : short // byte,sbyte,short,ushort,int,uint,long,ulong
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            /* 預先定義的數值型別，繼承於 System.ValueType 繼承於 System.Object (最基本的型別) */

            int i = 0; // int 為別名，真正是 System.Int32

            bool a = true; // bool 為別名，真正是 System.Boolean

            int intValue = 0; // 變數命名，採用駝峰表示，方法 Method 以大寫開頭，C#，區分大小寫
            Console.WriteLine(intValue); // 輸出 0

            int intValue2 = new int();
            Console.WriteLine(intValue2); // 輸出 0

            Person person = new Person();
            person.age = 10;
            Console.WriteLine(person.age); // 輸出 10

            Console.WriteLine(Days.Monday); // 輸出 Monday

            var day = Days.Friday; // var 匿名型別，隱式轉換
            Console.WriteLine(day); // 輸出 Friday

            var dayInt = (int)Days.Friday; // 強制轉換
            Console.WriteLine(dayInt); // 輸出 4

            var dayInt2 = (int)Days2.Friday; // 強制轉換
            Console.WriteLine(dayInt2); // 輸出 5

            var dayInt3 = (int)Days3.Friday; // 強制轉換
            Console.WriteLine(dayInt3); // 輸出 5
           
        }

        // struct 結構類型

        struct Person
        {
            // 存取修飾詞，未宣告存取修飾詞預設是 internal

            public int age; // public 公用的，任何地方都可以存取

            // protected string name; // protected 受保護的，限於類別或子類別中

            internal string firstName; // internal 內部的，限於目前的檔案中

            // protected internal string LastName; // 受保護的或內部的，限於目前的檔案或子類別中

            private string address; // private 私有的，限於類別中
        }
    }
}
