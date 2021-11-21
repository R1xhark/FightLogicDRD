using System;
using FightLogicDRD.Methods;

namespace FightLogicDRD
{
    class Program
    {
        static void Main(string[] args)
        {
            VytvorPostavu vytvor = new VytvorPostavu();
            vytvor.vytvorPostavu();

            SoubojEngine fight= new SoubojEngine();
            fight.souboj();
        }
    }
}
