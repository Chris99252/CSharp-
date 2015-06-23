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

            QuerySyntax();
        }

        // LINQ 三步驟

        private static void QuerySyntax()
        {
            // 1. Data Source
            // 必須實作IEnumerble：int

            int[] numbers2 = { 0, 1, 2, 3, 4, 5, 6, 7 };

            // 2. Query Creation

            var result = from num in numbers2 // 來源
                         where num % 2 == 0 // 條件
                         select num; // 結論

            // LINQ 預設是延遲載入，以下方法使用時才會強制執行

            int numCount = result.Count();

            result.ToList();

            result.ToArray();


            // 3. Query execution

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
