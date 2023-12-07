using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Valec : Teleso, IVykresy
    {
        internal int[] parametry = new int[2];
        public string Bokorys()
        {
            return $"kruh o poloměru "+ parametry[1]/2;
        }

        public override void NactiParametry()
        {
            Console.Write("Zadej délku válce: ");
            parametry[0] = int.Parse(Console.ReadLine());
            Console.Write("Zadej průměr válce: ");
            parametry[1] = int.Parse(Console.ReadLine());
        }

        public string Narys()
        {
            return $"obdélník o stranách {parametry[0]} a {parametry[1]}";
        }
        public override int ObjemTelesa()
        {
            return (int)Program.pi* parametry[1]* parametry[1]* parametry[0];
        }

        public override int PovrchTelesa()
        {
            return (int)Program.pi* parametry[1]*(parametry[1]+ parametry[0]);
        }

        public string Pudorys()
        {
            return $"obdélník o stranách {parametry[0]} a {parametry[1]}";
        }
    }
}
