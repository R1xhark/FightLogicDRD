using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightLogicDRD.Enemies;


namespace FightLogicDRD.Methods
{
    public class SoubojEngine
    {
       
        


    public void souboj()
        {
            sestistennaKostka sesticklenka = new sestistennaKostka();
            Postava Hrac = new Postava();
            BasicEnemy prvniProtivnik=new BasicEnemy();

            prvniProtivnik.Zivot = sesticklenka.hod(); prvniProtivnik.Obrana = sesticklenka.hod();
            prvniProtivnik.Obratnost = sesticklenka.hod();

            while (Hrac.zivoty!=0&&prvniProtivnik.Zivot!=0)
            {
                var Hraciniciativa = sesticklenka.hod();
                var ProtivnikInciativa = sesticklenka.hod();
                if (Hraciniciativa > ProtivnikInciativa)
                {
                    prvniProtivnik.BranSe();
                    Hrac.Utoc(prvniProtivnik,Hrac);
                }
                if (ProtivnikInciativa > Hraciniciativa)
                {
                    prvniProtivnik.Utoc(prvniProtivnik,Hrac);
                }
            }
            if (Hrac.zivoty.Equals(0)) { 
            Console.WriteLine("----------------------");
                Console.WriteLine("TVA POSTAVA ZEMRELA");
                Console.Read();
            }
            if (prvniProtivnik.Zivot.Equals(0))
            {
                Console.WriteLine("porazil jsi protivnika");
            }

        }

        }


        
    }

