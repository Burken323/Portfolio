using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWinFormsAssignment
{
    class Kurs
    {
        public string Namn { get; set; }

        public float Poäng { get; set; }

        public string SlutDatum { get; set; }

        public string StartDatum { get; set; }

        public double AntalKursDagar()
        {
            //"2018-08-24"

            DateTime start = DateTime.Parse(StartDatum);
            DateTime slut = DateTime.Parse(SlutDatum);
            TimeSpan span = slut - start;
            double antalDagar = span.Days;
            return antalDagar;
            //YY,MM,DD
        }

        public float PoängPerKursDag()
        {
            double dagar = AntalKursDagar();
            float poängPerKursDag = Poäng / (float)dagar;
            return poängPerKursDag;
        }
    }
}
