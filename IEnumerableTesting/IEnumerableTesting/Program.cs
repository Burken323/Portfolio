using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = new Employee[]
            {
                new Employee() {ID = 1, Name = "1"},
                new Employee() {ID = 2, Name = "2"},
                new Employee() {ID = 3, Name = "3"}
            };

            var enumerator = employees.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                Console.WriteLine(employee.Name);
            }
        }
    }
}
