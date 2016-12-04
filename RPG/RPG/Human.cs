using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Human
    {
        protected int maxHealth;

        protected int health;
        protected int damage;
        protected int heal;
        public int GetHealth()
        {
            return health;
        }
        public void Atack(Human enemy)
        {
            enemy.health -= this.damage;
        }
        public virtual void Health(Human enemy)
        {
            enemy.health += this.heal;
            if (enemy.health > enemy.maxHealth)
            {
                enemy.health = enemy.maxHealth;
            }
        }
        public virtual string WhoIAm()
        {
           return"Human";
        }
    }
}
