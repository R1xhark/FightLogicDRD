using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLogicDRD
{
    class VytvorPostavu
    {

        public void vytvorPostavuValecnik()
        {


            Postava vytvor = new Postava();
            DessetiStennaKostka desetistenka = new DessetiStennaKostka();
            sestistennaKostka sestistenka = new sestistennaKostka();
            vytvor.Typ = "Valecnik";
            while (vytvor.Obratnost.Equals(0) || vytvor.Jmeno.Equals(null) || vytvor.Sila.Equals(0) || vytvor.Obrana.Equals(0))
            {

                Console.WriteLine("Zadej jmeno postavy");
                vytvor.Jmeno = Console.ReadLine();

                vytvor.zivoty = 2 * (desetistenka.hod());
                Console.WriteLine("Vase zivoty jsou {0}", vytvor.zivoty);
                vytvor.Sila = 2 * (sestistenka.hod());
                Console.WriteLine("Vase sila je {0}", vytvor.Sila);
                vytvor.Obrana = 2 * (sestistenka.hod());
                Console.WriteLine("Vase Obrana je {0}", vytvor.Obrana);
                vytvor.Obratnost = sestistenka.hod();
                Console.WriteLine("Vase Obratnost je {0}", vytvor.Obratnost);



            }

        }
        public void vytvorPostavuMag()
        {


            Postava vytvor = new Postava();
            DessetiStennaKostka desetistenka = new DessetiStennaKostka();
            sestistennaKostka sestistenka = new sestistennaKostka();
            vytvor.Typ = "Mag";
            while (vytvor.Obratnost.Equals(0) || vytvor.Jmeno.Equals(null) || vytvor.Sila.Equals(0) || vytvor.Obrana.Equals(0))
            {

                Console.WriteLine("Zadej jmeno postavy");
                vytvor.Jmeno = Console.ReadLine();

                vytvor.zivoty = 2 * (desetistenka.hod());
                Console.WriteLine("Vase zivoty jsou {0}", vytvor.zivoty);
                vytvor.Inteligence = 2 * (sestistenka.hod());
                Console.WriteLine("Vase sila je {0}", vytvor.Sila);
                vytvor.Obrana = 2 * (sestistenka.hod());
                Console.WriteLine("Vase Obrana je {0}", vytvor.Obrana);
                vytvor.Obratnost = sestistenka.hod();
                Console.WriteLine("Vase Obratnost je {0}", vytvor.Obratnost);



            }

        }
        public void vytvorPostavuZlodej()
        {


            Postava vytvor = new Postava();
            DessetiStennaKostka desetistenka = new DessetiStennaKostka();
            sestistennaKostka sestistenka = new sestistennaKostka();
            vytvor.Typ = "Zlodej";
            while (vytvor.Obratnost.Equals(0) || vytvor.Jmeno.Equals(null) || vytvor.Sila.Equals(0) || vytvor.Obrana.Equals(0))
            {

                Console.WriteLine("Zadej jmeno postavy");
                vytvor.Jmeno = Console.ReadLine();

                vytvor.zivoty = 2 * (desetistenka.hod());
                Console.WriteLine("Vase zivoty jsou {0}", vytvor.zivoty);
                vytvor.Sila = 2 * (sestistenka.hod());
                Console.WriteLine("Vase sila je {0}", vytvor.Sila);
                vytvor.Obrana = 2 * (sestistenka.hod());
                Console.WriteLine("Vase Obrana je {0}", vytvor.Obrana);
                vytvor.Obratnost = sestistenka.hod();
                Console.WriteLine("Vase Obratnost je {0}", vytvor.Obratnost);



            }
        }
    }
}
