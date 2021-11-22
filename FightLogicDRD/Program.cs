using System;
using FightLogicDRD.Methods;

namespace FightLogicDRD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.Read();
            while (input != null) { 
            VytvorPostavu vytvor = new VytvorPostavu();
            vytvor.vytvorPostavu();

            SoubojEngine fight= new SoubojEngine();
            fight.souboj();
            }
        }
    }
}
