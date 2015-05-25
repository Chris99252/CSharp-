using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.索引子
{
    class Program
    {
        /// <summary>
        /// 索引子 indexer
        /// indexer的多型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var name = new IndexedNames();

            name[0] = "Hello";
            name[1] = "極客學院";
            name[2] = "We";
            name[3] = "are";
            name[4] = "learning";
            name[5] = "C#";
            name[6] = "indexer";
            name[7] = "-";
            name[8] = "indexer";
            name[9] = "syntax";

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine(name["C#"]); // 輸出：5
            Console.WriteLine(name["syntax"]); // 輸出：9
            Console.WriteLine(name["New"]); // 輸出：-1

        }
    }
    class IndexedNames
    {
        // 資料成員：array

        private string[] nameList = new string[10];

        // 建構函式給予 array 初始值

        public IndexedNames()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = "N/A";
            }
        }

        // 索引器：針對傳入的 index 對應的值

        public string this[int index] {
            get
            {
                string temp;

                // 判斷取值範圍是否合法

                if (index >=0 && index <= nameList.Length-1)
                {
                    temp = nameList[index];
                }
                else
                {
                    temp = "";
                }
                return temp;
            }

            set
            {
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    nameList[index] = value;
                }
            }
        }

        // 索引器 overload 多型

        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < nameList.Length)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }
                    else
                    {
                        index++;
                    }
                }

                return -1;
            }
        }

    }

    // 一個職員，給予一個年度 index ，回傳薪資
    // 職員不是一個薪資的集合體，不符合邏輯語意

    class Employee
    {
        public double this[int year]
        {
            get
            {
                // return salary
                return 0;
            }
        }
    }

    // interface 

    public interface ISomeInterface
    {
        int this[int index] { get; set; }
    }

    // 不夠強壯的代碼，沒有做任何合法判斷

    // 注意參數的合法範圍，空值異常判斷，存取修飾詞，盡可能用作小限度。

    class IndexerClass : ISomeInterface
    {
        private int[] arr = new int[100];

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}
