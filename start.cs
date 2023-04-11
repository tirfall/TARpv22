using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TARpv22
{
    public class start
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            //string paev = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    int nr = rnd.Next(1, 7);
            //    Console.WriteLine(nr);
            //    switch (nr)
            //    {
            //        case 1: paev = "Esmaspäev"; break;
            //        case 2: paev = "Teisipäev"; break;
            //        case 3: paev = "Kolmapäev"; break;
            //        case 4: paev = "Neljapäev"; break;
            //        case 5: paev = "Reede"; break;
            //        case 6: paev = "Laupäev"; break;
            //        case 7: paev = "Pühapäev"; break;
            //        default: paev = "Tundmatu päev"; break;
            //    }
            //    Console.WriteLine(paev);
            //}
            //int j = 0;
            //while (j<10) { Console.WriteLine(paev);j++;}
            //Console.WriteLine(j);
            //do { Console.WriteLine(paev); j--; } while (j!=0);
            //Console.WriteLine(j);

            //int[] arvud = new int[10];
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(-100, 100);
            //}
            //foreach (int arv in arvud) { if (arv < 0) { Console.Beep(); } Console.WriteLine(arv); }
            //System.Console.WriteLine("tere tulemast!\nMis on sinu nimi?");
            //string eesnimi = Console.ReadLine();
            //Console.WriteLine("Tere " + eesnimi);
            //Console.WriteLine("Arv1:");
            //int arv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Arv2:");
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tehe: ");
            //char tehe = char.Parse(Console.ReadLine());
            //if (tehe == '+')
            //{
            //    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 + arv2);
            //}
            //else if(tehe == '-')
            //{
            //    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
            //}

            //Esimene task

            //Console.WriteLine("tere tulemast!\nMis on sinu nimi?");
            //string nimi = Console.ReadLine();
            //if (nimi.ToLower() == "juku")
            //{
            //    Console.WriteLine("Tule minu juurde kinosse!\nKui vana on Juku?");
            //    int age =int.Parse(Console.ReadLine());
            //    if (age <= 6) { Console.WriteLine("Tasuta"); }
            //    else if (age<=15 ) { Console.WriteLine("Lastepilet"); }
            //    else if (age <= 65) { Console.WriteLine("täispilet"); }
            //    else if (age <= 100) { Console.WriteLine("sooduspilet"); }
            //    else { Console.WriteLine("vale vanus"); }
            //}
            //else
            //{
            //    Console.WriteLine("Täna mind kodus pole!");
            //}

            //Teine task

            //Console.WriteLine("tere tulemast!\nMis on esimene nimi?");
            //string nimi1 = Console.ReadLine();
            //Console.WriteLine("Mis on teine nimi?");
            //string nimi2 = Console.ReadLine();
            //Console.WriteLine("{0} ja {1}, te on täna pinginaabrid",nimi1,nimi2);

            //3 task

            //Console.WriteLine("Mis on ristkülikukujulise toa seinte pikkused?");
            //int pik1 = int.Parse(Console.ReadLine());
            //int pik2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Arvude {0} ja {1}, põranda pindala võrdub {2}", pik1, pik2, pik1 * pik2);
            //Console.WriteLine("kas sa tahad teha remonti?");
            //string remans = Console.ReadLine();
            //switch (remans.ToLower())
            //{
            //    case "jah":
            //        Console.WriteLine("Kui palju maksab ruutmeeter?");
            //        int hind = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Põranda vahetamise hind: {0}", hind * (pik1 * pik2));
            //        break;
            //    case "ei":
            //        Console.WriteLine("Head aega");
            //        break;
            //}

            //4 task

            //Console.WriteLine("Sisesta hind: ");
            //int hind1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(hind1 * 100 / 70);

            //5 task

            //Console.WriteLine("Milline temperatuur toalises?");
            //int temper = int.Parse(Console.ReadLine());
            //if (temper >= 18) { Console.WriteLine("Hea toaline temperatuur"); }

            //6 task

            //Console.WriteLine("Mis on sinu pikkus?");
            //int pikkus = int.Parse(Console.ReadLine());
            //if (pikkus <= 170) { Console.WriteLine("lühike"); }
            //else if (pikkus <= 190) { Console.WriteLine("keskmine"); }
            //else if (pikkus >= 190) { Console.WriteLine("pikk"); }

            //7 task

            //Console.WriteLine("Mis on sinu pikkus?");
            //int pikkus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mis on sinu segu? Naine või mees?");
            //string segu = Console.ReadLine();
            //if (segu.ToLower() == "mees" || segu.ToLower() == "naine")
            //{
            //    if (pikkus <= 170) { Console.WriteLine("Sa oled lühike ja sinu segu on {0}", segu); }
            //    else if (pikkus <= 190) { Console.WriteLine("Sa oled keskmine ja sinu segu on {0}", segu); }
            //    else if (pikkus >= 190) { Console.WriteLine("Sa oled pikk ja sinu segu on {0}", segu); }
            //}

            //Kordused ülesanned

            //1 task

            //int[] masarvud = new int[10];
            //for (int k = 0; k < masarvud.Length; k++)
            //{
            //    masarvud[k] = rnd.Next(-100, 100);
            //    masarvud[k] = rnd.Next(-100, 100);
            //}

            //2 task

            //int[] array = new int[5];
            //for (int h = 0; h != 5; h++) { array = int.Parse(Console.ReadLine()); }



            //Alamprogrammid

            //string nimi = "Aleks";
            //alamprog.Tere(nimi);
            //int a = 12;
            //int b = 15;
            //int vastus = alamprog.Korruta(a, b);
            //Console.WriteLine(vastus);
            //Console.WriteLine(alamprog.Korruta(5, 5));

            //1 task



            //2 task

            //Console.WriteLine("Sisesta esimene arv:");
            //int nurarv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta teine arv:");
            //int nurarv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta tehe:");
            //char nurtehe = char.Parse(Console.ReadLine());
            //Console.Write(alamprog.Nurrcalc(nurarv1, nurarv2, nurtehe));

            //3 task

            //Console.WriteLine("Sisesta kui palju tärnid sa tahad:");
            //int vastuskui = int.Parse(Console.ReadLine());
            //alamprog.Tarnid(vastuskui);

            //4 task
            Console.WriteLine("Kui palju rida sa tahad?");
            int vastus = int.Parse(Console.ReadLine());
            for (int n = 0; n != vastus; n++)
            {
                Console.WriteLine("Sisesta number:");
                int kolarv1 = int.Parse(Console.ReadLine());
                Console.WriteLine(alamprog.Kolmarv(kolarv1));
            }
                
        }
    }
}
