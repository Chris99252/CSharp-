using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.參考型別.Class.Interface.AbstractClass
{
    /// <summary>
    /// interface 與 class 差別在於，只能包含，方法，屬性，索引，事件，不能有資料成員與建構函示
    /// interface 沒有具體實現，需要在class方法內實現
    /// class 類別，若繼承了 interface 介面，必須實現 interface 內全部的方法
    /// abstract class 抽象類別 與 interface 的差別，抽象類別仍可以實作自己的方法(不限定是抽象方法)，可以包含資料成員
    /// 繼承 abstract class 的類別，必須 override 實作其抽象方法，而非抽象的方法，可以直接使用。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(5);

            // person.GetAgeInternal(); // 若未宣告存取修飾詞，預設是 internal，所以 person.GetAge() 不存在      

            Console.WriteLine(person.GetAge()); // 回傳 age，輸出 5

            // person.GetFive(); // 靜態方法與靜態成員，都只存在於自己的類別內，不能實例化變數，所以 person.GetFive() 不存在

            // Console.WriteLine(person.Number); // 靜態成員
          
            Console.WriteLine(Person.GetFive()); // 輸出 5

            Console.WriteLine(person.Age); // 輸出 0，有 get，可以取得值，int 默認值為零

            person.Age = 10; // 因為有 set ，可以賦值

            Console.WriteLine(person.Age); // 輸出 10

            Console.WriteLine(person.GetAge()); // 輸出 5

            Console.WriteLine(person.Age2); // 輸出 15，age 初始給予值 5，person.Age （get）設定 age = 5 + 10

            person.Age2 = 20; // age 初始給予值 5，person.Age2 （set）設定 age =  20 - 10

            Console.WriteLine(person.Age2); // 輸出 20，person.Age2 （get）設定 age = 10 + 10

            // Man m = new Man();  // 抽象類別是不能被實例化的

            Console.WriteLine(person.GetName()); // 抽象類別內的方法
        }
    }
    class Person : Man, ISuper // Person 類別 繼承了 ISuper 介面, Man 抽象類別，必須實現 ISuper 內全部的方法與 Man 內的抽象方法，不然會出錯。
    {
        // 資料成員 data member

        int age;

        // 屬性 Property

        public int Age { get; set; } //  age 為 private 資料成員，Property 提供一個可以讓外部使用的方式

        public static int Number { get; set; }

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

        int GetAgeInternal() // internal 內部的，限於目前的檔案中
        {
            return age;
        }

        public int GetAge() 
        {
            //string result = "5";
            //return result; // 無法將型別 'string' 隱含轉換為 'int'

            return age; // 回傳的型別與宣告的Method型別要一致
        }

        public static int GetFive() // 靜態方法
        {
            return 5;
        }

        // 實現介面 interface 的方法 Method

        public int GetSuper()
        {
            return age + 100;
        }

        public override int GetAbstract()
        {
            return 50;
        }
    }

    // 抽象類別 abstract class ，抽象類別是不能被實例化的，宣告方法，讓其他類別繼承，override 並實例化
    abstract class Man
    {
        public string name = "CSharp極客學園";

        public string GetName()
        {
            return name;
        }
        public abstract int GetAbstract();
    }


    interface ISuper // I 開頭
    {
        // public string name = "CSharp極客學園"; // 錯誤：介面不能包含資料成員
        int GetSuper(); // 沒有具體實現，需要在class方法內實現
    }
}
