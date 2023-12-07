using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    public class Krychle : Teleso, IVykresy
    {
        internal int delkaStrany;

        public string Bokorys()
        {
            return "čtverec o délce strany " + delkaStrany;       
                }

        public override void NactiParametry()
        {
            Console.Write( "Zadej délku strany krychle: ");
            delkaStrany = int.Parse(Console.ReadLine());  
        }

        public string Narys()
        {
            return "čtverec o délce strany " + delkaStrany;
        }

        public override int ObjemTelesa()
        {
            return delkaStrany * delkaStrany * delkaStrany;  
        }

        public override int PovrchTelesa()
        {
            return delkaStrany * delkaStrany * 6;
        }

        public string Pudorys()
        {
            return "čtverec o délce strany " + delkaStrany;
        }
    }
}
