using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD.Enemies
{
    class Mage
    {
        public int mana { get; set; }
        public int zivoty;

        public void FireBall()
        {
            mana--;
        }
        public void LightingAttack() {
            mana--;
        }
        public void FireStorm()
        {
            mana=-10;
        }
    }
}
