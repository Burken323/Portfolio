using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    class Customer : Human
    {
        public double Subscription { get; set; }

        public Customer(string name, string address, string phone, double subscription) : base(name, address, phone)
        {
            Subscription = subscription;
        }

        public override void TrainingSession()
        {
            Subscription -= 100;
        }
    }
}
