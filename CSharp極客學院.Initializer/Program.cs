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
            var student1 = new StudentName("Shih","Chris");
            var student2 = new StudentName { FirstName = "Shou", LastName = "Sand" };
            var student3 = new StudentName { ID = 100 };
            var student4 = new StudentName("Shih", "Panda") { ID = 102 };

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(student4.ToString());
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
}
