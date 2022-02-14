using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iskolaGUI2
{
    class tanulo
    {
        public int év { get; set; }
        public string osztály { get; set; }
        public string név { get; set; }

        public tanulo(string sor)
            {
            string[] t = sor.Split(';');
            év = int.Parse(t[0]);
            osztály = t[1];
            név = t[2];

            }

            
           

            





    }


    
}

