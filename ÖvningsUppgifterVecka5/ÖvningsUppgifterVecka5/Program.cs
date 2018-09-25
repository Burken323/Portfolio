using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyExtensions;

namespace ÖvningsUppgifterVecka5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string tal = "1,2";
            
            Console.WriteLine(tal.IsNumeric());

            string test = "nackademin yrkeshögskola";

            Console.WriteLine(test.FirstToUpperCase());

            Console.WriteLine("Day:");
            string day = Console.ReadLine();
            Console.WriteLine("Month:");
            string month = Console.ReadLine();
            Console.WriteLine("Year:");
            string year = Console.ReadLine();
            DateTime getLastDate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)).GetLastDayOfMonth();
            Console.WriteLine("Last day of that month: " + getLastDate);
           

            List<string> stringList = new List<string>();
            stringList.Add("1");
            stringList.Add("2");
            stringList.Add("3");
            stringList.Add("4");
            stringList.Add("5");
            Console.WriteLine(stringList.ListToString());

            

            List<string> tal = new List<string>();
            tal.Add("2", "4", "5", "10");

            for (int i = 0; i < tal.Count; i++)
            {
                Console.WriteLine(tal[i]);
            }
            */

            string[] bilar = { "Volvo", "BMW", "Audi", "Skoda",
                                "Toyota", "Ford", "Mercedes","Seat", "Honda",
                                    "Volkswagen","Opel", "Mazda","Suzuki" };

            var query1 = from bil in bilar
                         where bil.Equals("Opel")
                         select bil;

            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }

            var query2 = from bil in bilar
                         where bil.StartsWith("V")
                         select bil;

            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }

            var query3 = from bil in bilar
                         where bil.Contains("da")
                         select bil;

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }

            var query4 = from bil in bilar
                         where bil.StartsWith("M") || bil.EndsWith("i")
                         select bil;

            foreach (var item in query4)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


            

        }
    }
}
