using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學院.Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化基本語法

            ObjectInital();

            // 匿名類別（只允許 get）：常使用在LINQ

            AnonymousTypesInital();

            CollectionInital();
        }

        private static void ObjectInital()
        {
            var student1 = new StudentName("Shih", "Chris");
            var student2 = new StudentName { FirstName = "Shou", LastName = "Sand" };
            var student3 = new StudentName { ID = 100 };
            var student4 = new StudentName("Shih", "Panda") { ID = 102 };

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(student4.ToString());
        }

        private static void AnonymousTypesInital()
        {
            var pet = new { Age = 10, Name = "喵喵" };

            var students = new List<StudentName> 
            { 
                new StudentName("Li", "Li"), 
                new StudentName("Mei", "Mei") 
            };

            var studentsFroms = new List<StudentFrom> { 
                new StudentFrom{FirstName = "Li", City = "Taipei"},
                new StudentFrom{FirstName = "Mei", City = "Taichung"},
            };

            var queryJoin = from stu in students
                            join fro in studentsFroms on stu.FirstName equals fro.FirstName
                            select new { FirstName = stu.FirstName, LastName = stu.LastName, City = fro.City };

            foreach (var item in queryJoin)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.City);
            }
        }

        private static void CollectionInital()
        {
            var students = new List<StudentName> 
            {
                new StudentName {FirstName = "Mei", LastName = "Mei", ID = 100 },
                new StudentName() {FirstName = "Li", LastName = "Li", ID = 101 },
                new StudentName("Small", "White") { ID = 102 },
                null
            };

            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Dictionary<int, StudentName> studentDic = new Dictionary<int,StudentName>
            {
                { 111, new StudentName {FirstName = "Mei", LastName = "Mei", ID = 100 }},
                { 222, new StudentName() {FirstName = "Li", LastName = "Li", ID = 101 }},
                { 333, new StudentName("Small", "White") { ID = 102 }}
            };

            foreach (var item in studentDic)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }
    }

    public class StudentName
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

        public StudentName()
        {

        }

        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + ID; 
        }
    }

    public class StudentFrom
    {
        public string FirstName { get; set; }
        public string City { get; set; }

    }
}
