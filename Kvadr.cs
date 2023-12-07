using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Kvadr : Teleso, IVykresy
    {
        internal int[]parametry = new int[3];
        public string Bokorys()
        {
            return $"obdélnik o velikosti {parametry[1]} x {parametry[2]}";
        }

        public override void NactiParametry()
        {
            Console.Write("Zadej délku kvádru: ");
            parametry[0] = int.Parse(Console.ReadLine());
            Console.Write("Zadej šířku kvádru: ");
            parametry[1] = int.Parse(Console.ReadLine());
            Console.Write("Zadej výšku kvádru: ");
            parametry[2] = int.Parse(Console.ReadLine());
        }

        public string Narys()
        {
            return $"obdélnik o velikosti {parametry[0]} x {parametry[2]}";
        }

        public override int ObjemTelesa()
        {
            return parametry[0] * parametry[1] * parametry[2];       
        }

        public override int PovrchTelesa()
        {
             return parametry[0] * parametry[1] * 2+ parametry[0] * parametry[2] * 2+ parametry[1] * parametry[2] * 2;
        }

        public string Pudorys()
        {
            return $"obdélnik o velikosti {parametry[0]} x {parametry[1]}";
        }
    }
}
