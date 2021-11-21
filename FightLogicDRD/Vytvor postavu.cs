using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD
{
    class VytvorPostavu
    {

        private int vydrz;
        private int mana;
        private string jmeno;
        public int hod;

        public int kostka(int Hod)
        {
            this.hod = Hod;
            var kostka10 = new Random();
            Hod = kostka10.Next(1, 10);
            return Hod;
        }

        public int sila
        {
            get
            {
                return sila;
            }
            set
            {
                sila = hod;
            }
        }
        public int obrana
        {
            get
            {
                return obrana;
            }
            set
            {
                obrana = hod;
            }
        }
    }
}
