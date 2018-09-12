using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsForm
{
    class Meddelande
    {
        public string Text { get; set; }

        public string VisaMeddelande()
        {
            return "Hello World! " + Text;
        }
    }
}
