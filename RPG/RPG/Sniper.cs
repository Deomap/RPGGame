using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Sniper : Human
    {
        public Sniper()
        {
            health = 67;
            damage = 32;
            heal = 6;
            //1286,4
        }
        public override void WhoIAm()
        {
            Console.WriteLine("Sniper");
        }
    }
}
