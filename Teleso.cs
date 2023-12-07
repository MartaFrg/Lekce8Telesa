using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    public abstract class Teleso
    {
        public abstract void NactiParametry();
        public abstract int ObjemTelesa();
        public abstract int PovrchTelesa();
        public void VypisObjem()
        {
            Console.WriteLine(ObjemTelesa());
        }
        public void VypisPovrch()
        {
            Console.WriteLine(PovrchTelesa());
        }
    }
}
