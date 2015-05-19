using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學園.物件導向.繼承
{
    class Program
    {
        /// <summary>
        /// 繼承：當一個 舊的class，已經定義了許多的方法
        /// 新的class 可以重用舊的class的方法，也可以自行定義自己的方法
        /// 語意上的合理性：動物，狗。狗繼承了動物的特性。
        /// 只能繼承一個類別。不能多重繼承。
        /// 實例化子類別順序，先建構父類別，再建構子類別
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Age = 10; // 父類別 Animal 的屬性

            dog.Bite(); // 子類別 Dog override 的 Bite()

            dog.GetAge(); // 父類別 Animal 的 GetAge()

            dog.BiteMan(); // 父類別 Animal 的 BiteMan()

            Dog oldDog = new Dog(10);

            Animal animalFromDog = new Dog(); // 隱式轉換，向上轉型

            animalFromDog.Bite(); // 子類別 Dog 的 Bite()

            animalFromDog.BiteMan(); // 父類別 Animal 的 BiteMan() 

            ((Dog)animalFromDog).BiteMan(); // 強制轉換，執行 子類別 Dog 的 BiteMan()
        }
        class Animal
        {
            public int Age { get; set; }

            public Animal() // 建構函式1
            {
                Console.WriteLine("Animal constructor");
            }

            public Animal(int age) // 建構函式2
            {
                Console.WriteLine("Old Animal constructor");
                this.Age = age;
            }

            public virtual void Bite() // virtual 可以被 子類別 override
            {
                Console.WriteLine("Animal bite");
            }

            public virtual void GetAge()
            {
                Console.WriteLine(this.Age);
            }

            public void BiteMan() // 未告宣 virtual
            {
                Console.WriteLine("Animal bite man");
            }
        }

        sealed class Dog : Animal // Dog 繼承了 Animal，宣告為 sealed 封閉的，代表無法被繼承
        {
            public Dog() // 建構函式1
            {
                Console.WriteLine("Dog constructor");
            }

            //public Dog(int age) // 建構函式2：先執行默認的父類別的建構函式1，再建構子類別的建構函式2
            //{
            //    Console.WriteLine("Old Dog constructor");
            //    this.Age = age;
            //}

            //public Dog(int age) : base(age)// 建構函式2，加上 base(age)：執行父類別的建構函式2，再建構子類別的建構函式2
            //{
            //    Console.WriteLine("Old Dog constructor");
            //    this.Age = age;
            //}

            public Dog(int age)
                : this() // 建構函式2，加上 this()，先執行默認的父類別的建構函式1，再建構子類別的建構函式1，最後建構子類別的建構函式2
            {
                Console.WriteLine("Old Dog constructor");
                this.Age = age;
            }

            public override void Bite() // override 重寫了 Dog 的 Bite()
            {
                Console.WriteLine("Dog bite");
            }

            //public override void BiteMan() //  錯誤，方法未宣告為 virtual
            //{
            //    Console.WriteLine("Dog bite man");
            //}

            public new void BiteMan() //  警告，如果刻意要隱藏，請使用關鍵字 new : 意思相當於，把父類別的同名方法隱藏。
            {
                Console.WriteLine("Dog bite man");
            }
        }

        //class LittleDog : Dog // 錯誤：無法衍生自密封型別
        //{
            
        //}
    }
}
