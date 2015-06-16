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
            string s1 = "abc123";
            string pattern = @"abc";
            Console.WriteLine(Regex.IsMatch(s1,pattern)); // 輸出：true
            
            var r1 = new Regex(@"123"); // 連續 123
            Console.WriteLine(r1.IsMatch("abcd123")); // abcd[123]

            var r5 = new Regex(@"[123]"); //  1 或 2 或 3
            Console.WriteLine(r5.IsMatch("abcd123")); // abcd[1][2][3]

            var r2 = new Regex(@"\d"); // 只要是數字
            Console.WriteLine(r2.IsMatch("abcd123")); //  abcd[1][2][3]

            var r3 = new Regex(@"."); // 任何的字符
            Console.WriteLine(r3.IsMatch("abcd123.")); //  [a][b][c][d][1][2][3][.]

            var r4 = new Regex(@"\."); // 只有 .
            Console.WriteLine(r4.IsMatch("abcd123.")); //  abcd123[.]

            var r6 = new Regex(@"c{2}"); // 連續兩個c
            Console.WriteLine(r6.IsMatch("abccd123")); //  ab[cc]d123

            var r7 = new Regex(@"c{2,3}"); // 最少連續兩個c, 最多連續三個c
            Console.WriteLine(r7.IsMatch("abcccd123")); //  ab[ccc]d123

            var r8 = new Regex(@"c*"); // 有零個c 或 多個c
            Console.WriteLine(r8.IsMatch("abcccd123")); // []a[]b[ccc][]d[]1[]2[]3[]

            var r9 = new Regex(@"c+"); // 一個c 或 多個c
            Console.WriteLine(r9.IsMatch("acbccd123")); // a[c]b[cc]d123

            var r10 = new Regex(@"c?"); // 一個c 或 沒有c
            Console.WriteLine(r10.IsMatch("acbccd123")); // []a[c][]b[c][c][]d[]1[]2[]3[]

            var r11 = new Regex(@"\s"); // 一個空白
            Console.WriteLine(r11.IsMatch("hello jikexueyuan ")); // hello[ ]jikexueyuan[ ]

            var r12 = new Regex(@"\S"); // 不是空白
            Console.WriteLine(r12.IsMatch("hello jikexueyuan ")); // [h][e][l][l][o] [j][i][k][e][x][u][e][y][u][a][n] 

            var r13 = new Regex(@"^hello.*"); // hello 開頭，後面全部
            Console.WriteLine(r13.IsMatch("hello jikexueyuan ")); // [hello jikexueyuan ]

            var r14 = new Regex(@"^hello.*xueyuan$"); // hello 開頭，xueyuan 結束
            Console.WriteLine(r14.IsMatch("hello jikexueyuan")); // [hello jikexueyuan]

            var r15 = new Regex(@"(hello)"); // 有 hello 字串
            Console.WriteLine(r15.IsMatch("hello jikexueyuan")); // [(<1>hello)] jikexueyuan

            var r16 = new Regex(@"(hello).*(xueyuan)"); // 有 hello 與 xueyuan 字串
            Console.WriteLine(r16.IsMatch("hello jikexueyuan")); // [(<1>hello) (<2>xueyuan)]

            var r17 = new Regex(@"(.*)"); // 全部字串
            Console.WriteLine(r17.IsMatch("hello jikexueyuan")); // [(<1>hello jikexueyuan)][(<1>)]

            var r18 = new Regex(@"(hello|xueyuan)"); // hello 或 xueyuan 字串
            Console.WriteLine(r18.IsMatch("hello jikexueyuan")); // [(<1>hello)] jike[(<1>xueyuan)]

            var r19 = new Regex(@"\w"); // 所有的字符
            Console.WriteLine(r19.IsMatch("hello jikexueyuan *&^%$#")); // [h][e][l][l][o] [j][i][k][e][x][u][e][y][u][a][n] *&^%$#

            var r20 = new Regex(@"\W"); // 不是字符的
            Console.WriteLine(r20.IsMatch("hello jikexueyuan *&^%$#")); // hello[ ]jikexueyuan[ ][*][&][^][%][$][#]

            string[] values = { "111-22-3333", "111-2-3333" };

            var pattern2 = @"^\d{3}-\d{2}-\d{4}$";

            foreach (var item in values)
            {
                if (Regex.IsMatch(item,pattern2))
                {
                    Console.WriteLine("{0} is valid", item);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", item);
                }
            }
        }
    }
}
