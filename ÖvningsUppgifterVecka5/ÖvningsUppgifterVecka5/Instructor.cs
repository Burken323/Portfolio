using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    class Instructor : Human
    {
        public double Salary { get; set; }

        public Instructor(string name, string address, string phone, double salary) : base(name, address, phone)
        {
            Salary = salary;
        }

        public override void TrainingSession()
        {
            Salary += 100;
        }
    }
}
