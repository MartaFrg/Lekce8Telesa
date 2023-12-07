using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Jehlan : Teleso, IVykresy
    {
        internal int[] parametry = new int[2];
        public string Bokorys()
        {
            return $"rovnoramenný trojúhelník se podstavou {parametry[0]} a výškou {parametry[1]}";
        }

        public override void NactiParametry()
        {
            Console.Write("Zadej délku strany podstavy: ");
            parametry[0] = int.Parse(Console.ReadLine());
            Console.Write("Zadej výšku jehlanu: ");
            parametry[1] = int.Parse(Console.ReadLine());
        }

        public string Narys()
        {
            return $"rovnoramenný trojúhelník se podstavou {parametry[0]} a výškou {parametry[1]}";
        }

        public override int ObjemTelesa()
        {
            return parametry[0]* parametry[0]* parametry[1]/3;
        }

        public override int PovrchTelesa()
        {
            return parametry[0]*(parametry[0]+ parametry[1]); //není přesný vzorec
        }

        public string Pudorys()
        {
            return "čtverec o straně "+ parametry[0];
        }
    }
}
