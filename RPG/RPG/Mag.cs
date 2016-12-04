using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Mag : Human
    {
        public Mag()
        {
            maxHealth = 75;
            health = maxHealth;
            damage = 25;
            heal = 7;
            //1312,5
        }
        public override void WhoIAm()
        {
            Console.WriteLine("Mage");
        }
        public override void Health(Human enemy)
        {
            //ничего не должно происходить
        }
    }
}
