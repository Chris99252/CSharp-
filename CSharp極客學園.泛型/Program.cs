using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.泛型
{
    /// <summary>
    /// 泛型：宣告一個泛型，不同的型別，都可以叫用。提高類別的重用性。確保類型是一致的，安全的。提高性能。
    /// </summary>

    delegate T NumberChange<T>(T n);
    class Program
    {
        static int num = 10;
        static string s1 = "Hello";

        // delegate 泛型委派

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static string MultString(string p)
        {
             s1 += p;
            return s1;
        }

        static void Main(string[] args)
        {
            NumberChange<int> nc1 = new NumberChange<int>(AddNum);

            NumberChange<string> nc2 = new NumberChange<string>(MultString);

            nc1(25);
            Console.WriteLine(num);

            nc2(" World");
            Console.WriteLine(s1);

            // int

            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            for (int i = 0; i < 5; i++)
            {
                intArray.SetItem(i, i * 5);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }

            Console.WriteLine();

            intArray.GenericMethod<string>("Hello Generic!");
            intArray.GenericMethod<int>(100);

            // char

            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            for (int i = 0; i < 5; i++)
            {
                charArray.SetItem(i, (char)(i + 97));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(charArray.GetItem(i) + " ");
            }
            
            Console.WriteLine();

            int a, b;
            char c, d;

            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Console.WriteLine("a = {0}; b = {1}", a, b);
            Console.WriteLine("c = {0}; d = {1}", c, d);

            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            Console.WriteLine("a = {0}; b = {1}", a, b);
            Console.WriteLine("c = {0}; d = {1}", c, d);

        }
        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    //宣告一個泛型的 class<T> 限制 T 必須為實值型別

    // Dictionary

    public class MyGenericArray<T> where T : struct
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }

        public void GenericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }
    }

    //public class SubClass : MyGenericArray<int>
    //{

    //}

    //public class SubGenericClass<T> : MyGenericArray<T> where T : struct
    //{

    //}
}
