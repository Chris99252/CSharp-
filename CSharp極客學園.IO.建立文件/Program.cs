using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp極客學園.IO.建立文件
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";
        static void Main(string[] args)
        {
            // 建立文件

            //if (File.Exists(FILE_NAME))
            //{
            //    Console.WriteLine("{0} already Exists", FILE_NAME);
            //    return;
            //}
            //else
            //{
            //    FileStream fs = new FileStream(FILE_NAME, FileMode.Create);
            //    BinaryWriter w = new BinaryWriter(fs);

            //    for (int i = 0; i < 11; i++)
            //    {
            //        w.Write("a");
            //    }
            //    w.Close();
            //    fs.Close();
            //}

            // 替原有的文件，增加內容

            using (StreamWriter w = File.AppendText("Test.txt")) // 檔案附加文字
            {
                Log("呵呵",w);
                Log("Hello 極客學院", w);

                w.Close();
            } // 執行生命週期，using 結束即 crash 掉，減少資源浪費
           
            // IO讀寫，資料庫連接，也是消耗資源的動作，盡量使用 using 
        }
        public static void Log(string logMessage, TextWriter w) // 靜態方法，將內容 logMessage 寫入檔案
        {
            w.Write("\r\nLog Entry：");
            w.WriteLine("{0}", logMessage);

            w.Flush(); // 清除寫入緩衝區
        }
    }
}
