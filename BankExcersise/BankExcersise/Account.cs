using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExcersise
{
    class Account
    {
        public decimal Saldo { get; set; }
        public string KontoNr { get; set; }

        public Account(string kontoNr, decimal saldo)
        {
            KontoNr = kontoNr;
            Saldo = saldo;
        }
    }
}
