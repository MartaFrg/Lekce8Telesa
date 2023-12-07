using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8Telesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teleso> list = new List<Teleso>();
            Teleso teleso = new Krychle();
            teleso.NactiParametry();
            list.Add(teleso);
            list[0].VypisPovrch();

        }
    }
}
