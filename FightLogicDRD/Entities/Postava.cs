using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightLogicDRD.Enemies;

namespace FightLogicDRD
{
    public class Postava
    {

        public int Obrana { get; set; }
        public int Sila { get; set; }
        public int Obratnost { get; set; }
        public string Jmeno { get; set; }

        public int zivoty { get; set; }

        public static void vytvorPostavu()
        {
            
        }
        public void Utoc(BasicEnemy Enemy,Postava Hrac)
        {
            Enemy.Zivot = -Hrac.Sila;
        }
    }
}  