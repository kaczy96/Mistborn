using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn
{
    class Ekwipunek
    {
        public int Obrazenia { get; set; }
        public int Wytrzymalosc { get; set; }
        public int Obrona { get; set; }

        public int Error { get; set; }
        


        int Atak_bronia()
        {
            if (Wytrzymalosc > 0)
                return Obrazenia;
            else
                return Error;
        }
    }
}
