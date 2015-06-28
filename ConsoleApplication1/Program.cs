using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學院.ExtensionMethod
{

    public enum Grades
    {
        F = 0,
        D = 1,
        C = 2,
        B = 3,
        A = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoLinq();

            StringCount();

            GradePassing();
        }

        private static void DemoLinq()
        {
            int[] numbers = { 10, 45, 15, 39, 21, 36 };

            // 使用 System.Linq 內的 （擴充方法） OrderBy，也叫語法糖。

            var result = numbers.OrderBy(n => n);

            foreach (var item in result)
            {
                Console.WriteLine("{0} ", item);
            }
        }

        private static void StringCount()
        {
            string s = "This is jikexueyuan C# tutorial";

            int i = s.WordCount();

            Console.WriteLine("Word count of s is {0}", i);
        }

        private static void GradePassing()
        {
            var g1 = Grades.D;
            var g2 = Grades.F;
            var g3 = Grades.C;

            Console.WriteLine("First {0} a passing grade", g1.Passing() ? "is" : "is not");
            Console.WriteLine("First {0} a passing grade", g2.Passing() ? "is" : "is not");
            Console.WriteLine("First {0} a passing grade", g3.Passing() ? "is" : "is not");

            GradesEnumExtension.minPassing = Grades.C;

            Console.WriteLine("First {0} a passing grade", g1.Passing() ? "is" : "is not");
            Console.WriteLine("First {0} a passing grade", g2.Passing() ? "is" : "is not");
            Console.WriteLine("First {0} a passing grade", g3.Passing() ? "is" : "is not");
        }
    }

    // 擴充方法：靜態的類別，靜態的方法，參數對於哪一個類型進行擴充 this 關鍵字

    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class GradesEnumExtension
    {
        public static Grades minPassing = Grades.D;

        public static bool Passing(this Grades grade)
        {
            return grade >= minPassing;
        }
    }
}
