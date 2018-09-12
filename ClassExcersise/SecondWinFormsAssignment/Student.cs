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

        public string Förnamn { get; set; }

        public string Telefon { get; set; }

        public float HämtaBetyg()
        {
            float Betyg = 0;
            Kurs crs = new Kurs();
            if(crs.Namn == (Förnamn + " " + Efternamn))
            {
                Betyg = crs.Poäng;
            }
            return Betyg;
        }
    }
}
