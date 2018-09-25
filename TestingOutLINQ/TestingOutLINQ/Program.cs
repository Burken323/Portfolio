using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOutLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            
            ShowLargeFilesWithLINQ(path);


        }

        private static void ShowLargeFilesWithLINQ(string path)
        {
            //Method syntax.
            var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length).Take(5);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name,-20} : {item.Length,10:N0}");
            }
            //Query Syntax. (from, in, where, orderby, descending, select).
        }
    }
}
