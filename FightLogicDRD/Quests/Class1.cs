using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD.Quests
{
    class Quest1
    {
        public static void Odposlech()
        {
            Postava Hrac = new Postava();
            if (Hrac.Obratnost > 5)
            {
                Console.WriteLine("za dvermi jsi slysel");
            }
            if (Hrac.Obratnost < 5)
            {
                Console.WriteLine("za dvermi neslysis nic");
            }
        }
    }
}
