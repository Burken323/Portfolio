using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWinFormsAssignment
{
    class Student
    {
        public string Efternamn { get; set; }

        public string Email { get; set; }

        public string PersonNummer { get; set; }

        public string Förnamn { get; set; }

        public string Telefon { get; set; }

        Kurs crs;

        public float HämtaBetyg()
        {
            float Betyg = 0;
            
            if(crs.Namn == (Förnamn + " " + Efternamn))
            {
                Betyg = crs.Poäng;
            }
            return Betyg;
        }

        public bool KontrolleraVärden(string missing)
        {
            if(Förnamn == String.Empty)
            {
                Form2.missing = "Förnamn";
                return false;
            }
            if(Efternamn == String.Empty)
            {
                missing = "Efternamn";
                return false;
            }
            if(PersonNummer == String.Empty)
            {
                missing = "Personnummer";
                return false;
            }
            if(Telefon == String.Empty)
            {
                missing = "Telefon";
                return false;
            }
            if(Email == String.Empty)
            {
                missing = "Email";
                return false;
            }
            return true;
        }
    }
}
