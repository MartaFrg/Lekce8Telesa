using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Kuzel : Teleso, IVykresy
    {
        internal int[] parametry = new int[2];
        public string Bokorys()
        {
            return $"rovnoramenný trojúhelník se podstavou {parametry[0]} a výškou {parametry[1]}";
        }

        public override void NactiParametry()
        {
            Console.Write("Zadej průměr podstavy: ");
            parametry[0] = int.Parse(Console.ReadLine());
            Console.Write("Zadej výšku kužele: ");
            parametry[1] = int.Parse(Console.ReadLine());
        }

        public string Narys()
        {
            return $"rovnoramenný trojúhelník se podstavou {parametry[0]} a výškou {parametry[1]}";
        }

        public override int ObjemTelesa()
        {
            return (int)Program.pi * parametry[0] * parametry[0] * parametry[1]/3;
        }

        public override int PovrchTelesa()
        {
            return (int)Program.pi* parametry[0]*(parametry[0]); //toto není úplně přesný vzorec
        }

        public string Pudorys()
        {
            return "kruh o poloměru "+ parametry[0]/2;
        }
    }
}
