using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExcersise
{
    class Bank
    {
        public string Name { get; set; }

        public List<Account> Konton { get; private set; }

        public Bank()
        {
            Konton = new List<Account>();
        }
    }
}
