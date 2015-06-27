using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp極客學院.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // linq：Lanuage Intergarted Query

            // Select id, name from tableName 無法進類型檢查

            // IEnumerable

            // LINQ to SQL, LING to XML, LINQ to DataSet, LINQ to Objects

            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            // 1. Query syntax

            var data = from num in numbers // from 開頭
                       where num % 2 == 0 // where 條件
                       orderby num // orderby 排序
                       select num; // select 放最後

            foreach (var item in data)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            // 2. Method syntax

            var data2 = numbers.Where(p => p % 2 == 0).OrderBy(p => p);

            foreach (var item in data2)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();

            QuerySyntax();

            QueryOperations();
        }

        // LINQ 三步驟

        private static void QuerySyntax()
        {
            // 1. Data Source
            // 必須實作IEnumerble：int

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };

            // 2. Query Creation

            var result = from num in numbers // 來源
                         where num % 2 == 0 // 條件
                         select num; // 結論

            // LINQ 預設是延遲載入，以下方法使用時才會強制執行

            int numCount = result.Count();

            result.ToList();

            result.ToArray();


            // 3. Query execution
            
            foreach (var item in result)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();


        }

        private static void QueryOperations()
        {
            int[] numbers = { 0, 1, 2, 4, 6, 7 };

            // 基本操作 select

            var querySelect = from num in numbers
                        select num;

            // 條件判斷 where

            var queryWhere = from num in numbers
                         where num % 2 == 1
                         select num;

            // 多條件判斷 where and

            var queryWhereAnd = from num in numbers
                         where num % 2 == 1 && num % 3 == 1
                         select num;

            foreach (var item in queryWhereAnd)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();

            // 多條件判斷 where or

            var queryWhereOr = from num in numbers
                         where num % 2 == 1 || num % 3 == 1
                         select num;

            foreach (var item in queryWhereOr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            // 排序 orderby 升冪排序

            var queryOrderASC = from num in numbers
                         where num % 2 == 1 || num % 3 == 1
                         orderby num // ascending
                         select num;

            foreach (var item in queryOrderASC)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            // 排序 orderby 降冪排序

            var queryOrderDES = from num in numbers
                         where num % 2 == 1 || num % 3 == 1
                         orderby num descending
                         select num;

            foreach (var item in queryOrderDES)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            // Group by

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Chris", City = "Taiwan" });
            customers.Add(new Customer() { Name = "Cash", City = "USA" });
            customers.Add(new Customer() { Name = "Will", City = "Taiwan" });

            var queryGoup = from c in customers
                         group c by c.City;

            foreach (var cg in queryGoup)
            {
                Console.WriteLine(cg.Key);

                foreach (var c in cg)
                {
                    Console.WriteLine(" {0}",c.Name);
                }
            }

            Console.WriteLine();
            
            // join 

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Name = "Chris", ID = 101 });
            employees.Add(new Employee { Name = "Cash", ID = 102 });

            var queryJoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonID = e.ID, PersonCity = c.City };

            foreach (var item in queryJoin)
            {
                Console.WriteLine("{0} {1} {2}", item.PersonID, item.PersonName, item.PersonCity);
            }
        }

        class Customer
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        class Employee
        {
            public string Name { get; set; }

            public int ID { get; set; }
        }
    }
}
