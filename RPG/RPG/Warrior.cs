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
            maxHealth = 120;
            health = maxHealth;
            damage = 18;
            heal = 6;
            //1296
        }
        public override string WhoIAm()
        {
            return "Warrior";
        }
        public override void Health(Human enemy)
        {
            //ничего не должно происходить
        }
    }
}
