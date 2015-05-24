using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp極客學園.IO.讀取文件
{
    class Program
    {
        /// <summary>
        /// using System.IO
        /// File, Directory
        /// FileInfo, DirectoryInfo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 檢查文件是否存在
            
            var result = File.Exists(@"C:\HelloIO\IO.txt"); // 傳入 path，回傳 boolean
            Console.WriteLine(result); // 輸出：false

            var result2 = File.Exists(@"C:\HelloIO\IO2.txt"); // 傳入 path，回傳 boolean
            Console.WriteLine(result2); // 輸出：true

            // 檢查資料夾是否存在

            var result3 = Directory.Exists(@"C:\");
            Console.WriteLine(result3); // 輸出：true

            // 取得特地資料夾下，所有 .exe 檔的所有資訊

            string path = "."; // 目前路徑

            if (args.Length > 0) // 檢查是否有參數傳入
            {
                if (Directory.Exists(args[0])) // 檢查第一個參數，是否為正確路徑
                {
                    path = args[0]; // 將路徑值賦予給 path
                } 
                else
                {
                    Console.WriteLine("{0} not found; using current directory", args[0]);
                }
            }

            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (FileInfo item in dir.GetFiles("*.exe")) // GetFiles 有三個多型
            {
                string name = item.Name; // 檔案名稱
                long size = item.Length; // 長度
                DateTime creationTime = item.CreationTime; // 建立時間
                Console.WriteLine("{0} {1, -20:g} {2}", size, creationTime, name);
            }
        }
    }
}
