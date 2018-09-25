using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    public static class MyExtensions
    {
        public static bool IsNumeric(this string tal)
        {
            return double.TryParse(tal, out double trash);
        }

        public static string FirstToUpperCase(this string text)
        {
            string[] temp = text.Split(' ');
            string result = "";
            foreach (var word in temp)
            {
                result += word.First().ToString().ToUpper() + word.Substring(1);
                result += " ";
            }
            return result;
        }

        public static DateTime GetLastDayOfMonth(this DateTime userInput)
        {
            var lastDay = DateTime.DaysInMonth(userInput.Year, userInput.Month);
            var temp = lastDay - userInput.Day;
            DateTime lastDayOfMonth = userInput.AddDays(temp);
            return lastDayOfMonth;
        }

        public static string ListToString(this List<string> stringList)
        {
            StringBuilder sb = new StringBuilder();
            for (var word = 0; word < stringList.Count; word++)
            {
                sb.Append(stringList[word]);
                if((stringList.Count - 1) == word)
                {
                    sb.Append(".");
                    break;
                }
                sb.Append(", ");
            }

            return sb.ToString();
        }

        public static List<string> Add(this List<string> addedNumbers, params string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                addedNumbers.Add(numbers[i]);
            }

            return addedNumbers;
        }
    }
}
