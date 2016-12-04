using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Druid : Human
    {
        public Druid()
        {
            maxHealth = 78;
            health = maxHealth;
            damage = 10;
            heal = 17;
            //1326
        }
        public override string WhoIAm()
        {
            return "Druid";
        }

    }
}
