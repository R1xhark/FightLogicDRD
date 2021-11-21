using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD.Enemies
{
    public class BasicEnemy
    {
        public int Zivot { get; set; }
        public int Obrana { get; set; }
        public int Obratnost { get; set; }

        public void Utoc(BasicEnemy Enemy,Postava Hrac)
        {
            Hrac.zivoty = -Enemy.Obratnost;
        }
        public void BranSe(BasicEnemy Enemy, Postava Hrac)
        {

        }
        
        public void Umri()
        {
            Console.WriteLine("BasicEnemy umira");
        }
    }
}
