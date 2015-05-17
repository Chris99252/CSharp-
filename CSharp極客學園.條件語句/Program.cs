using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.條件語句
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if 條件判斷式

            bool condition = true;
            int ten = 10;
            object objectNull = null;
            // if (!false | (bool)objectNull) // 輸出錯誤例外：第一個通過，後面仍會運算
            //if (!false || false) // 輸出 True Condition：第一個通過，後面就不運算了
            if (ten > 100)
            {
                Console.WriteLine("True Condition");
                if (true)
                {
                    Console.WriteLine("True and True");
                }
            }
            else if(ten > 5) 
            {
                Console.WriteLine("ten > 5 and ten < 100"); 
            }
            else
            {
                Console.WriteLine("ten <= 5"); 
            }
            ten = 101;
            int ifalse = ten < 100 ? ten : 99; // 輸出 99。如果滿足 『?』 前的條件，回傳原值 ; 不滿足，回傳 『:』 後的值

            Console.WriteLine(ifalse);

            // switch 條件式

            int switchKey = 100;

            switch (switchKey)
            {
                case 10:
                    Console.WriteLine("switchKey is 10");
                    break;
                case 100:
                    Console.WriteLine("switchKey is 100");
                    break;
                default:
                    Console.WriteLine("I don't know switchKey");
                    break;
            }
            #endregion

            #region loop 迴圈

            // 簡單的 for 迴圈

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                //if (i == 3)
                //{
                //    break;
                //}
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine("After Condition");
            }

            // 複雜的 for 迴圈

            int k;
            int j = 10;
            for (k = 0,Console.WriteLine("Start：{0}",k); k < j ; k++ , j-- ,Console.WriteLine("i={0},j={1}",k,j))
            {
                Console.WriteLine("Body of the loop");
            }

            // 無窮迴圈

            //for ( ; ; )
            //{
            //    Console.WriteLine("Can't u stop");
            //}

            bool stop = false;
            for (;!stop ; )
            {
                stop = true;
                Console.WriteLine("Can't u stop");
            }

            // foreach 迴圈

            // 傳入的集合，必須有實作 IEnumerable 介面

            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (var item in listInt)
            {
                Console.WriteLine(item);
            }

            // 同義的寫法

            IEnumerator ie = listInt.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }

            // while 迴圈

            int n = 1;

            while (n++ < 6) // n++：n = n + 1。先用 n 去判斷，再加一。輸出：2,3,4,5,6
            {
                Console.WriteLine("n is {0}", n);
            }

            while (++n < 6) // ++n：n = n + 1。先將 n 加一，再判斷。輸出：2,3,4,5
            {
                Console.WriteLine("n is {0}", n);
            }

            // do while 迴圈

            do
            {
                Console.WriteLine("至少跑一遍");
            }
            while (false);

            #endregion
        }
    }
}
