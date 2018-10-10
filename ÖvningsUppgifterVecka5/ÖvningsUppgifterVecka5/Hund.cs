using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    class Hund
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public HundOwner Owner { get; set; }
        public static int CountOfDogs = 0;

        public Hund()
        {

        }

        public Hund(string name, string color, HundOwner owner)
        {
            Name = name;
            Color = color;
            Owner = owner;
            CountOfDogs++;

        }
    }
}
