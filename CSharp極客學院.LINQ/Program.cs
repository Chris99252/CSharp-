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
                Console.WriteLine(item);
            }

            // 2. Method syntax

            var data2 = numbers.Where(p => p % 2 == 0).OrderBy(p => p);

            foreach (var item in data2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
