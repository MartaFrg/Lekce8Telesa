using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Koule : Teleso, IVykresy
    {
        internal int polomer;

        public string Bokorys()
        {
            return $"Kruh o průměru {polomer * 2}.";
        }

        public override void NactiParametry()
        {
            Console.WriteLine("Zadej poloměr koule.");
        }

        public string Narys()
        {
            return $"Kruh o průměru {polomer * 2}.";
        }

        public override int ObjemTelesa()
        {
            return (int)(4 * 3.14 * polomer * polomer * polomer);
                }

        public override int PovrchTelesa()
        {
            return (int)(4 * 3.14 * 2);       
                }

        public string Pudorys()
        {
            return $"Kruh o průměru {polomer * 2}.";
        }
    }
}
