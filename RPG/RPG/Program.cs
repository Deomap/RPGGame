using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
 class Mainn
    {
        private static int countPlayer;
        private static int round = 1;
       public static Human[] secondTeam = new Human[3];
       public static Human[] firstTeam = new Human[3];
        public static Human activePers = firstTeam[0];
        public static Human ativeEnemy = firstTeam[0];
        private static Human activeEnemy;
        public static Human activeGHeal = firstTeam[0];
        public static void Main(string[] args)
        {
            Random rand = new Random();
            
           
            firstTeam[0] = new Mag();
            firstTeam[1] = new Warrior();
            firstTeam[2] = new Druid();
           
            secondTeam[0] = new Mag();
            secondTeam[1] = new Warrior();
            secondTeam[2] = new Druid();
            
            Console.WriteLine("Первым ходит...");
             countPlayer = rand.Next(1, 3);
            Console.WriteLine("{0}й игрок", countPlayer);

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine(round);
                if (countPlayer == 1)
                {
                    Console.WriteLine("Первый игрок, выберите персонажа, которым хотите ходить:");
                    switch (persChoice())
                    {
                        case 1: activePers = firstTeam[0];firstAttack(); break;
                        case 2: activePers = firstTeam[1]; firstAttack(); break;
                        case 3: activePers = firstTeam[2];firstheal(); break;
                    }

                }
                else
                {
                    Console.WriteLine("Второй игрок, выберите персонажа, которым хотите ходить:");
                    switch (persChoice())
                    {
                        case 1: activePers = secondTeam[0]; secondAttack(); break;
                        case 2: activePers = secondTeam[1]; secondAttack(); break;
                        case 3: activePers = secondTeam[2];secondheal(); break;
                    }
 
                }
            }
        }
        public void nl()
        {
            Console.WriteLine();
        }
        public static int persChoice()
        {
            Console.WriteLine("1) Маг");
            Console.WriteLine("2) Воин");
            Console.WriteLine("3) Друид");
            char choose = Console.ReadKey().KeyChar;
            return choose;
        }
        public static void firstAttack()
        {

                Console.WriteLine("Выберите, кого атаковать из команды врага:");
                switch (persChoice())
                {
                    case 1: activeEnemy = secondTeam[0]; break;
                    case 2: activeEnemy = secondTeam[1]; break;
                    case 3: activeEnemy = secondTeam[2]; break;
                }

                endOfAtack();
                endingHealth();
            

        }
        public static void secondAttack()
        {


                Console.WriteLine("Выберите, кого атаковать из команды врага:");
                switch (persChoice())
                {
                    case 1: activeEnemy = firstTeam[0]; break;
                    case 2: activeEnemy = firstTeam[1]; break;
                    case 3: activeEnemy = firstTeam[2]; break;
                }
                endOfAtack();
                endingHealth();
            }
        
        public static void endOfAtack()
        {
            activePers.Atack(activeEnemy);
            activeEnemy.backAtack(activePers);
           
        }
        public static void endingHealth()
        {
            Console.WriteLine("Здоровье {0} :   {1}", activePers.WhoIAm(), activePers.GetHealth());
            Console.WriteLine("Здоровье {0} :   {1}", activeEnemy.WhoIAm(), activeEnemy.GetHealth());
        }
        public static void firstheal()
        {
            Console.WriteLine("Выберите, кого вылечить из союзных персонажей:");
            switch (persChoice())
            {
                case 1: activeGHeal = firstTeam[0]; break;
                case 2: activeGHeal = firstTeam[1]; break;
                case 3: activeGHeal = firstTeam[2]; break;
            }

        }
        public static void secondheal()
        {
            Console.WriteLine("Выберите, кого вылечить из союзных персонажей:");
            switch (persChoice())
            {
                case 1: activeGHeal = secondTeam[0]; break;
                case 2: activeGHeal = secondTeam[1]; break;
                case 3: activeGHeal = secondTeam[2]; break;
            }
        }
        public static void endingHeal()
        {
            activePers.Health(activeGHeal);
            endingHealth();
        }
        public static void switcher()
        {
            if (countPlayer == 2)
            {
                countPlayer = 1;
            }
            else
            {
                countPlayer = 2;
            }
            round++;
        }
    }
}
