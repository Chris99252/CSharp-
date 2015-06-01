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
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }

    //宣告一個泛型的 class<T>
    public class MyGenericArray<T>
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
    }
}
