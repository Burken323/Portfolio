using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    class Order
    {
        public List<Pizza> Pizzas { get; set; }

        public Order()
        {
            Pizzas = new List<Pizza>();
        }

        public void GetPrice()
        {
            double total = 0;
            foreach (var item in Pizzas)
            {
                total += item.Price;
            }
            Console.WriteLine("Total price for the order: " + total);
        }
    }
}
