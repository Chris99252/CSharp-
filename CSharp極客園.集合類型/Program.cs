using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.集合類型
{
    class Program
    {
        /// <summary>
        /// 長度需要被宣告，是固定的
        /// 有同一個類型的型別組成
        /// 根據 index 來進行排序，索引的起始為零
        /// Array 是固定的，很難彈性運用
        /// ArrayList 讓我們可以新增刪除，增加彈性，可以存各種型別
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Array

            // 陣列：繼承 System.Array

            int[] numbers = new int[5]; // 一維陣列

            string[,] names = new string[5, 4]; // 二維陣列

            byte[][] scores = new byte[5][]; 

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}",i,scores[i].Length);
            }

            int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 }; // 長度可以不用給，系統自己判

            int[] numbers4 = { 1, 2, 3, 4, 5 }; // 甚至連實例化都幫你做完

            string[,] names2 = { { "g", "k" }, { "h", "j" } };

            int[][] scores2 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 } };

            Console.WriteLine(numbers2[2]); // 輸出：3

            Console.WriteLine(numbers2.Length); // 輸出常數：5

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region ArrayList

            // List,ArraryList System.Collection

            ArrayList al = new ArrayList();

            al.Add(5);
            al.Add(100);
        
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(al[0]);

            al.Remove(5);
            al.Add("CSharp極客園"); // 可以存取各種型別

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region List
            
            // Array 沒有宣告存取型別，建議使用 List ，降低錯誤 

            List<int> intList = new List<int>();

            intList.Add(500); // 增加一個元素
            intList.AddRange(new int[] { 501, 502 }); // 增加一串元素
            intList.Contains(200); // 是否包含 200
            Console.WriteLine(intList.Contains(200)); // 輸出：False
            Console.WriteLine(intList.IndexOf(501)); // 輸出：1
            intList.Remove(501);
            intList.Insert(1, 1001); // 插入到指定的 index 位置

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
