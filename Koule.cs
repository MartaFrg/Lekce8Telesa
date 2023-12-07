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
            return $"kruh o průměru {polomer * 2}.";
        }

        public override void NactiParametry()
        {
            Console.Write("Zadej poloměr koule: ");
            polomer = int.Parse(Console.ReadLine());
        }

        public string Narys()
        {
            return $"kruh o průměru {polomer * 2}.";
        }

        public override int ObjemTelesa()
        {
            return (int)(4 * Program.pi * polomer * polomer * polomer/3);
                }

        public override int PovrchTelesa()
        {
            return (int)(4 * Program.pi * 2);       
                }

        public string Pudorys()
        {
            return $"kruh o průměru {polomer * 2}.";
        }
    }
}
