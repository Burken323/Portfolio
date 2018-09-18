using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();

            var a1 = new Account("12345", 1000.00m);
            var a2 = new Account("12325", 2000.00m);
            var a3 = new Account("12335", 3000.00m);

            bank.Konton.Add(a1);
            bank.Konton.Add(a2);
            bank.Konton.Add(a3);
           
            bank.Konton.

            foreach(var item in bank.Konton)
            {

            }
        }
    }
}
