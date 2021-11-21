using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD
{
    class ctyrstennakostka
    {
        public int hod()
        {
            Random kostka = new Random();
            int hodnota=kostka.Next(1, 4);
            return hodnota;
        }
    }
}
