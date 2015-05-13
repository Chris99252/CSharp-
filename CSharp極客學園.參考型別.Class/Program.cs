using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.參考型別.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(5);

            // 若為宣告存取修飾詞，預設是 internal p.GetAge() 不存在

            Console.WriteLine(person.GetAge()); // 回傳 age，輸出 5

            Console.WriteLine(Person.GetFive()); // 輸出 5

            // 靜態方法與靜態成員，都只存在於自己的類別內，不是在實例化變數，所以 person.GetFive() 不存在

            Console.WriteLine(person.Age); // 輸出 0，有 get，可以取得值，int 默認值為零

            person.Age = 10; // 因為有 set ，可以賦值

            Console.WriteLine(person.GetAge());

            Console.WriteLine(person.Age2); // 輸出 15，age 初始給予值 5，person.Age （get）設定 5 + 10


        }
    }
    class Person
    {
        // 資料成員 data member

        int age;

        // 屬性 Property

        public int Age { get; set; } //  age 為 private 資料成員，Property 提供一個可以讓外部使用 age 的方式

        public int Age2
        { 
            get
            {
                return age + 10;
            }
            set
            {
                age = value - 10;
            }
        }

        // 建構函式 Constructor

        public Person(int myAge)  
        {
            // 建構式
            this.age = myAge; // this 整個 Person class 內的 age
        }

        // 方法 Method

        public int GetAge() // 存取修飾詞 internal，內部的，限於目前的檔案中
        {
            //string result = "5";
            //return result; // 無法將型別 'string' 隱含轉換為 'int'

            return age; // 回傳的型別與宣告的Method型別要一致
        }

        public static int GetFive() // 靜態方法
        {
            return 5;
        }
    }
}
