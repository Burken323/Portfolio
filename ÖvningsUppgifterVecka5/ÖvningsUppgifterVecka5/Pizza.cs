using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    class Pizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Pizza(string name, double price)
        {
            Name = name;
            Price = price;
            Ingredients = new List<Ingredient>();
        }
    }
}
