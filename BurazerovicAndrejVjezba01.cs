using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurazerovicProjekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIJABLE!

            int ocjena, brojOcjena = 0, i = 0;
            double prosjek = 0, zbrojOcjena = 0; 

            //ZAGLAVLJE APLIKACIJE!

            Console.WriteLine("######################");
            Console.WriteLine("Izračunavanje prosjeka");
            Console.WriteLine("######################");
            Console.WriteLine("Unesi nulu za kraj programa");

            //OBRADA

            do
            {
                brojOcjena++; //brojac ocjena
                Console.WriteLine("Unesi ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());
                if (ocjena > 1 && ocjena <= 5) // ako je broj > 1 i <= 5 program ga sprema kao ocjenu
                {
                    zbrojOcjena += ocjena;
                }
                else if (ocjena == 1) //ako je ocjena negativna prosjek je automatski q
                {
                    Console.WriteLine("Zakljucna ocjena je negativna");
                    prosjek = 1;
                    break;
                }
                else if(ocjena !=0) // ako ni jedan od prijasnjih uvjeta nije zadovoljen a broj nije 0 korisnika se trazi ponovni unos
                {
                    Console.WriteLine("Uneseni broj nije u rasponu ocjena! Ponovno unesi ocjenu: ");
                    i -= 1;
                    brojOcjena -= 1;

                }
                

            } while (ocjena != 0); //uvje twhile petlje, sve dok broj nije 0 petlja se ispisuje


            //ISPIS!
            if (prosjek != 1) //ako je prosjek 1 ne ispisuje ga, ako nije 1 racuna ga i ispisuje ga
            {
                prosjek = zbrojOcjena / (brojOcjena-1);
                Console.WriteLine("Prosjek ocjena je " + prosjek);
            }

            Console.ReadKey();
        }
    }
}
