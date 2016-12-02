using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior : Human
    {
        public Warrior()
        {
            health = 120;
            damage = 18;
            heal = 6;
            //1296
        }
        public override void WhoIAm()
        {
            Console.WriteLine("Warrior");
        }
    }
}
