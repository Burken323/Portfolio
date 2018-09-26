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
            */

            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth",
                                "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis",
                                   "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers",
                                    "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple",
                                        "U2"};
            /*
            var query1 = from band in bands
                         where band.Length == bands.Max(b => b.Length)
                         select band;

            foreach (var band in query1)
            {
                Console.WriteLine(band);
            }

            var query2 = from band in bands 
                         where band.Length == bands.Min(b => b.Length)
                         select band;

            foreach (var band in query2)
            {
                Console.WriteLine(band);
            }

            var query3 = (from band in bands
                         where band.StartsWith("M")
                         select band).ToList();

            Console.WriteLine(query3.Count);

            var query4 = from band in bands
                         where band.Length > 6 orderby band
                         select band;

            foreach (var band in query4)
            {
                Console.WriteLine(band);
            }
            
            var query5 = (from band in bands
                         orderby band.Length
                         select band).ToList();

            foreach (var band in query5)
            {
                Console.WriteLine(band);
            }

            string text = "lol;hej;tjena";
            Console.WriteLine(text);
            string[] split = text.Split(';');
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }
            string newText = string.Join(";", split);

            Console.WriteLine(newText);
            

            List<int> integers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489, 88 };

            var query = (from tal in integers
                        select tal).Average();

            Console.WriteLine(query);

            var query2 = (from tal in integers
                         select tal).Max();

            Console.WriteLine(query2);

            var query3 = (from tal in integers
                          select tal).Min();

            Console.WriteLine(query3);

            var query4 = (from tal in integers
                          select tal).Sum();

            Console.WriteLine(query4);

            var query5 = from tal in integers
                         where tal % 2 == 0
                          select tal;

            foreach (var item in query5)
            {
                Console.WriteLine(item);
            }

            var queryList = Enumerable.Range(1, 10).ToList();

            foreach (var item in queryList)
            {
                Console.WriteLine(item);
            }
            */

            int[] lista = { 1, 3, 5, 7 };

            var query = (from tal in lista
                        select tal + 2).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


            

        }
    }
}
