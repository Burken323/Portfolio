using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyExtensions;

namespace ÖvningsUppgifterVecka5
{
    class Program
    {
        enum Seasons { Summer, Autumn, Winter, Spring }

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
            

            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth",
                                "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis",
                                   "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers",
                                    "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple",
                                        "U2"};
            
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
            

            int[] lista = { 1, 3, 5, 7 };

            var query = (from tal in lista
                        select tal + 2).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            

            int[] test = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rnd.Next(1, 11);
            }
            int numbers = 0;
            int result = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if(test[i] % 3 == 0)
                {
                    result += test[i];
                    numbers++;
                }
            }
            double medel = (double)result / numbers;
            Console.WriteLine("Medelvärde: " + medel);

            Console.ReadKey();
            */

            //1.Skapa en enumeration av årsider
            //enum { Sommar, Höst, Vinter, Vår }


            //3.Spara strängen i uppg. 2 i en textfil ”Tal.txt”

            //4 Läs in strängen från filen i uppg3 och gör om den till en array av int

            //5.Skapa en klass som beskriver en Hund. Hunden har ett namn, en färg och en ägare.
            //Ägaren skall komma från en klass Hundägare som ärver från klassen Person(Namn, adress, telefon)

            //6.Deklarera en array av klassen Hund samt lägg in 2 hundar i arrayen.
            //7.Skapa en funktionalitet i klassen Hund där du kan ta reda på hur många hundar det finns
            //registrerade(instansierade) skriv kod för hur man får veta antal hundar.
            //8.Du har talen 265 - 290 Dra roten ur alla jämna tal och addera rötterna.Skriv ut summan


            //string test = "231596874";

            //Console.WriteLine(Sort(test));
            //Console.ReadLine();
            /*
            Person personEtt = new Person("Stefan", "Brunnvägen 6", "023 344 56 84");
            //personEtt.
            HundOwner ownerEtt = new HundOwner("Stefan", "Brunnvägen 8", "023 344 56 84", "1234");
            
            
            Hund HundEtt = new Hund("Kalle", "Brun", ownerEtt);
            Hund HundTwo = new Hund("Balle", "Svart", ownerEtt);
            Hund[] hunds = { HundEtt, HundTwo };
            Console.WriteLine(Hund.CountOfDogs);
            Console.WriteLine("Ägarens namn samt hundens namn:");
            Console.WriteLine(HundEtt.Owner.Name);
            Console.WriteLine(HundEtt.Name);

            double result = 0;
            for (int i = 265; i < 291; i++)
            {
                if(i % 2 == 0)
                {
                    result += Math.Sqrt(i);
                }
            }
            Console.WriteLine(result);

            string namn ="Kurt, Oskar, Sven, Nils".Replace(" ", "");
            string[] namnArray = namn.Split(',');
            foreach (var item in namnArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < namnArray.Length; i++)
            {
                for (int j = 0; j < namnArray.Length; j++)
                {
                    if(namnArray[i].ElementAt(0) < namnArray[j].ElementAt(0))
                    {
                        sb.Append(namnArray[i]);
                        namnArray[i] = namnArray[j];
                        namnArray[j] = sb.ToString();
                        sb.Clear();
                    }
                }
            }
            foreach (var item in namnArray)
            {
                Console.WriteLine(item);
            }

            int one = 5;
            int two = 2;
            int sum = 0;
            int diff = 0;

            GetSumAndDiff(one, two, out sum, out diff);
            Console.WriteLine(sum + " " + diff);

            int[] tal = { 11, 11, 12, 12, 13, 13, 14, 15, 16 };
            int[] nyaTal = new int[6];
            int index = 0;
            nyaTal[0] = tal[0];
            for (int i = 0; i < tal.Length; i++)
            {
                bool add = true;
                if(nyaTal[index] == tal[i])
                {
                    add = false;
                }
                if (add)
                {
                    index++;
                    nyaTal[index] = tal[i];
                }
            }
            foreach (var item in nyaTal)
            {
                Console.Write(item + " ");
            }
            */
            string withVowels = "Flygande beckasiner söka whila på mjuka tufvor";

            StringBuilder sb = new StringBuilder();
            string tmp = withVowels.ToUpper();
            string vowels = "AOUÅEIYÄÖ";

            for (int i = 0; i < withVowels.Length; i++)
            {
                if (vowels.Contains(tmp[i]))
                {
                    continue;
                }
                sb.Append(withVowels[i]);
            }
            Console.WriteLine(sb.ToString());

            int result = 0;
            for (int i = 1; i < 1001; i++)
            {
                if(i % 17 == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);

            int test = (int)Seasons.Summer;

            Console.WriteLine(test);

            var enumTest = (Seasons)3;

            Console.WriteLine(enumTest);

            var obj = new
            {
                Namn = "Kurt",
                Adress = "Bergsgatan 21",
                Postnummer = 11228,
                Ort = "Stockholm"
            };

            using (var writer = new StreamWriter("objekt.txt"))
            {
                string line = string.Join(";", new string[]
                {
                    obj.Namn,
                    obj.Adress,
                    obj.Postnummer.ToString(),
                    obj.Ort
                });
                writer.WriteLine(line);
            }
            
            using(var reader = new StreamReader("objekt.txt"))
            {
                string line = reader.ReadLine();
                string[] items = line.Split(';');
                var objTwo = new
                {
                    Namn = items[0],
                    Adress = items[1],
                    Postnummer = int.Parse(items[2]),
                    Ort = items[3]
                };
                Console.WriteLine(objTwo.Namn);
                Console.WriteLine(objTwo.Adress);
                Console.WriteLine(objTwo.Postnummer);
                Console.WriteLine(objTwo.Ort);
            }

            int[] array = new int[] { 3, 2, 4, 1, 7, 8, 11 };
            int result2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    result2 += array[i];
                }

            }
            Console.WriteLine(result2);

            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int total = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains('a'))
                {
                    total++;
                }
            }
            Console.WriteLine(words.Length);
            Console.WriteLine(total);

            var longestShortest = FindString(words);
            Console.WriteLine(longestShortest);

            Console.WriteLine();

            string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom", "Lisa Lind" };
            var efternamn = (from namn in namnLista
                            orderby namn.Split(' ')[1].ElementAt(0)
                            select namn).ToList();

            var efternamn2 = namnLista.OrderBy(x => x.Substring(x.LastIndexOf(' '))).ToList();

            foreach (var item in efternamn2)
            {
                Console.WriteLine(item);
            }

            Pizza pizzaOne = new Pizza("Vesuvio", 70.0);
            pizzaOne.Ingredients.Add(new Ingredient("Ost"));
            pizzaOne.Ingredients.Add(new Ingredient("Tomat"));
            pizzaOne.Ingredients.Add(new Ingredient("Skinka"));
            Pizza pizzaTwo = new Pizza("Capriciosa", 75.0);
            pizzaOne.Ingredients.Add(new Ingredient("Ost"));
            pizzaOne.Ingredients.Add(new Ingredient("Tomat"));
            pizzaOne.Ingredients.Add(new Ingredient("Skinka"));
            pizzaOne.Ingredients.Add(new Ingredient("Champinjoner"));

            Order orderOne = new Order();
            orderOne.Pizzas.Add(pizzaOne);
            orderOne.Pizzas.Add(pizzaTwo);
            orderOne.GetPrice();
            Start();
            CalculateMinutes();
            Console.WriteLine();

            //
            string lol = "Naturrutan";
            string rofl = lol.ToLower().Replace(" ", "");
            char[] kaos = rofl.ToCharArray();
            for (int i = 0; i < lol.Length/2; i++)
            {
                char temp = kaos[i];
                kaos[i] = kaos[(lol.Length - 1) - i];
                kaos[(lol.Length - 1) - i] = temp;
            }
            string newRofl = new string(kaos);
            Console.WriteLine(newRofl);
            if (rofl.Equals(newRofl))
            {
                Console.WriteLine("This is a palindrome.");
            }
            else
            {
                Console.WriteLine("Lol, fel.");
            }
            //


            Console.ReadLine();


        }

        public static void CalculateMinutes()
        {
            Console.WriteLine("Amount of minutes: ");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int minutes))
            {
                if(minutes < 60)
                {
                    Console.WriteLine("Minutes: " + minutes);
                }
                else if(minutes > 60 && minutes < 24 * 60)
                {
                    int hours = minutes / 60;
                    Console.WriteLine("Hours: " + hours);
                    minutes = minutes % 60;
                    Console.WriteLine("Minutes: " + minutes);
                }
                else
                {
                    int days = minutes / (24*60);
                    Console.WriteLine("Days: " + days);
                    int temp = minutes % (24*60);
                    int hours = temp / 60;
                    Console.WriteLine("Hours: " + hours);
                    minutes = minutes % 60;
                    Console.WriteLine("Minutes: " + minutes);
                }
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }

        public static void Start()
        {
            Console.WriteLine("Första input: ");
            string value1 = Console.ReadLine();
            Console.WriteLine("Andra input: ");
            string value2 = Console.ReadLine();
            double result = Calculate(value1, value2);
            Console.WriteLine(result);
        }

        private static double Calculate(string value1, string value2)
        {
            if(double.TryParse(value1, out double realValue1))
            {
                if(double.TryParse(value2, out double realValue2))
                {
                    return (double)realValue1 * realValue2;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public static Tuple<string,string> FindString(string[] words)
        {
            string longest = "";
            string shortest = "";
            string temp = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if(words[i].Length < words[j].Length)
                    {
                        temp = words[j];
                        words[j] = words[i];
                        words[i] = temp;
                    }
                }
            }
            longest = words[words.Length-1];
            shortest = words[0];

            return Tuple.Create(longest, shortest);
        }

        //2 Sortera strängen "231596874" till strängen "123456789" med en egen sortfunktion

        public static string Sort(string input)
        {
            var letters = input.ToCharArray();
            var temp = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if(letters[i] < letters[j])
                    {
                        temp = letters[i];
                        letters[i] = letters[j];
                        letters[j] = temp;
                    }
                    
                }
            }
            return new string(letters);
        }

        public static void GetSumAndDiff(int one, int two, out int sum, out int diff)
        {
            sum = one + two;
            diff = one - two;
        }

    }
}
