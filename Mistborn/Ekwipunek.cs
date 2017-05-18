using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn
{
    class Ekwipunek
    {
        public int Damage { get; set; }
        public int Endurance { get; set; }
        public int Defense { get; set; }

        public int Error { get; set; }
        


        int Weapon_atack()
        {
            if (Endurance > 0)
                return Damage;
            else
                return Error;
        }
    }
}
