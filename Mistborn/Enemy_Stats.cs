using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn
{
    class Enemy_Stats
    {
        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        public int Defense { get; set; }
        public int Metal_bottle { get; set; }
        
        int atak()
        {
            return Agility * Strength * (Luck / 3);
        }

        int Self_Defense()
        {
            return Agility * Defense * (Luck / 3);
        }

        int atakspecjalny()
        {
            return (Metal_bottle * 5) * Luck;
        }
    }
}
