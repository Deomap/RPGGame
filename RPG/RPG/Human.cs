using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Human
    {
        public int health;
        public int damage;
        public int heal;
        public void Atack(Human enemy)
        {
            enemy.health -= this.damage;
        }
        public void Heal(Human player)
        {
            player.health += this.heal;
        }
        public virtual void WhoIAm()
        {
            Console.WriteLine("Human");
        }
    }
}
