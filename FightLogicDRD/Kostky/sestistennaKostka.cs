using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD
{
    class sestistennaKostka
    {
        public int hod()
        {
            Random kostka = new Random();
            int hodnota = kostka.Next(1, 6);
            return hodnota;
        }
    }
}
   
