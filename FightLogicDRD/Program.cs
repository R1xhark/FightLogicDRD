using System;
using FightLogicDRD.Methods;

namespace FightLogicDRD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vitej v menu");
            Console.WriteLine("/v vytvor postavu");
            Console.WriteLine("/f random souboj");
            Console.WriteLine("/e odejdi ze hry");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Zadej vyber:");
            var input = Console.ReadLine();
            while (input != null&&input!="/e") {
                if (input.Equals("/v"))
            {
                var inputTyp = Console.ReadLine();
                
                
                    if (inputTyp.Equals("Valecnik")) { 
                        VytvorPostavu vytvor = new VytvorPostavu();
                    vytvor.vytvorPostavuValecnik();
                    }
                    if (inputTyp.Equals("Mag"))
                    {
                        VytvorPostavu vytvor = new VytvorPostavu();
                        vytvor.vytvorPostavuMag();
                    }
                    if (inputTyp.Equals("Zlodej"))
                    {
                        VytvorPostavu vytvor = new VytvorPostavu();
                        vytvor.vytvorPostavuZlodej();
                    }
                }
                if (input.Equals("/f"))
                {
                    SoubojEngine fight = new SoubojEngine();
                    fight.souboj();
                }
              
            }
            if (input.Equals("/e"))
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("pro ukonceni stiskni libovolnou klavesu"); Console.Read();
            }
        }
    }
}
