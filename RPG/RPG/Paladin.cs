using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Paladin : Human
    {
        public Paladin()
        {
            health = 155;
            damage = 6;
            heal = 14;
            //1302
        }
        public override void WhoIAm()
        {
            Console.WriteLine("Paladin");
        }
    }
}
