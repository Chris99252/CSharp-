using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp極客學園.IO.獲取文件
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";
        static void Main(string[] args)
        {
            // FileStream

            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                string input;

                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                Console.WriteLine("The end of he stream");
                sr.Close();
            }

            //if (!File.Exists(FILE_NAME))
            //{
            //    Console.WriteLine("{0} does not exist!");
            //    return;
            //}
            //else
            //{
            //    FileStream fs = new FileStream(FILE_NAME, FileMode.Open,FileAccess.Read);
            //    BinaryReader r = new BinaryReader(fs);
            //    for (int i = 0; i < 11; i++)
            //    {
            //        Console.WriteLine(r.ReadString());
            //    }

            //    r.Close();
            //    fs.Close();
            //}
        }
    }
}
