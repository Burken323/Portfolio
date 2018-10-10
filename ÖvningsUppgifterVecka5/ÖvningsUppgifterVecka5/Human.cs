using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    abstract class Human
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Human(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public abstract void TrainingSession();
    }
    
}
