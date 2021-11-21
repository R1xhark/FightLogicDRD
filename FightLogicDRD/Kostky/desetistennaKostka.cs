using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD
{
    class DessetiStennaKostka
    {
        public int hod()
        {
            Random kostka = new Random();
            int hodnota = kostka.Next(1, 10);
            return hodnota;
        }
    }
}
