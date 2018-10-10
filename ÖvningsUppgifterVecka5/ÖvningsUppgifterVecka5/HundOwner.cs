using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifterVecka5
{
    class HundOwner : Person
    {
        public string OwnerID { get; set; }

        public HundOwner() : base()
        {
            OwnerID = "0";
        }

        public HundOwner(string name, string address, string phone, string ownerid) : base(name, address, phone)
        {
            OwnerID = ownerid;
        }
    }
}
