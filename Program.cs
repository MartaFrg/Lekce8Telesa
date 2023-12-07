using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Program
    {
        public const double pi = 3.14159;
        static void Main(string[] args)
        {
            List<Teleso> listTeles = new List<Teleso>();
            int volba=0;
            while (volba != 8)
            {
                Console.WriteLine("Zadej typ tělesa:\t1. koule \n\t\t\t2. krychle\n\t\t\t3. kvádr\n\t\t\t4. jehlan\n\t\t\t5. kužel\n\t\t\t6. válec\n\t\t\t7. vypiš všechny uložené tvary\n\t\t\t8. UKONČIT");
                volba = int.Parse(Console.ReadLine());
                Teleso teleso;
                switch (volba)
                {
                    case 1:
                        teleso = new Koule();
                        teleso.NactiParametry();
                        listTeles.Add(teleso);
                        break;
                    case 2:
                        teleso = new Krychle();
                        teleso.NactiParametry();
                        listTeles.Add(teleso);
                        break;
                    case 3:
                        teleso = new Kvadr();
                        teleso.NactiParametry();
                        listTeles.Add(teleso);
                        break;
                    case 4:
                        teleso = new Jehlan();
                        teleso.NactiParametry();
                        listTeles.Add(teleso);
                        break;
                    case 5:
                        teleso = new Kuzel();
                        teleso.NactiParametry();
                        listTeles.Add(teleso);
                        break;
                    case 6:
                        teleso = new Valec();
                        teleso.NactiParametry();
                        listTeles.Add(teleso);
                        break;
                    case 7:
                        foreach (Teleso t in listTeles)
                        {
                            Console.WriteLine($"{t.GetType().Name} - objem: {t.ObjemTelesa()} - povrch: {t.PovrchTelesa()}");
                        }
                        Console.WriteLine($"");
                        break;
                    case 8:
                        System.Environment.Exit(0);
                        break;
                }
                if (volba < 7 && volba > 0)
                {
                    listTeles.Last().VypisObjem();
                    listTeles.Last().VypisPovrch();
                    Console.WriteLine("Půdorys je " + ((IVykresy)listTeles.Last()).Pudorys());
                    Console.WriteLine("Nárys je " + ((IVykresy)listTeles.Last()).Narys());
                    Console.WriteLine("Bokorys je " + ((IVykresy)listTeles.Last()).Bokorys());
                    Console.WriteLine("");
                }
            }

        }
    }
}
