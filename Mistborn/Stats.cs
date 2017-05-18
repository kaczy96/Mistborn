using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn
{
    public class Stats
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        public int Defense { get; set; }
        public int Metal_bottle { get; set; }
        public int Gift { get; set; }

       
        int atak()
        {
            return Agility * Strength * (Luck/2) * Gift;
        }

        int obrona()
        {
            return Agility * Defense * (Luck/2) * Gift;
        }

        int atakspecjalny()
        {
            return (Metal_bottle*5) * Luck * Gift;
        }
        
    }
}
