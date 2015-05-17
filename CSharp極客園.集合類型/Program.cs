using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客園.集合類型
{
    class Program
    {
        /// <summary>
        /// 長度需要被宣告，是固定的
        /// 有同一個類型的型別組成
        /// 根據 index 來進行排序，索引的起始為零
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 陣列：繼承 System.Arrary

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
        }
    }
}
