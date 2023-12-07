using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    public class Krychle : Teleso
    {
        internal int delkaStrany;
        public override void NactiParametry()
        {
            Console.WriteLine( "Zadej délku strany krychle.");
            delkaStrany = int.Parse(Console.ReadLine());  
        }

        public override int ObjemTelesa()
        {
            return delkaStrany * delkaStrany * delkaStrany;  
        }

        public override int PovrchTelesa()
        {
            return delkaStrany * delkaStrany * 6;
        }
    }
}
