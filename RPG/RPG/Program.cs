using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    class Program : PlayerData
    {
        public static string[] choicePersonList = new string[5];

        static Human player1;
        static Human player2;

        public static void choiceChar()
        {
            for (int i = 0; i < choicePersonList.Length; i++)
            {
                Console.WriteLine(choicePersonList[i]);
            }
        }

        public static void choice()
        {
            choicePersonList[0] = "Снайпер";
            choicePersonList[1] = "Паладин";
            choicePersonList[2] = "Друид";
            choicePersonList[3] = "Воин";
            choicePersonList[4] = "Маг";
        }
        public static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            MainReCharge:
            Char key;
            int countPlayer = 0;
            Human mag = new Mag();
            Human warrior = new Warrior();
            Human sniper = new Sniper();
            Human paladin = new Paladin();
            Human druid = new Druid();
            choice();
            Random rand = new Random();

            Console.WriteLine("");

            Console.WriteLine("Игрок 1, выберите персонажа, которым хотите играть:");
            Console.WriteLine("1 - Снайпер");
            Console.WriteLine("2 - Паладин");
            Console.WriteLine("3 - Друид");
            Console.WriteLine("4 - Воин");
            Console.WriteLine("5 - Маг");
            key = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (key)
            {
                case '1': player1 = new Sniper(); p1Person = "Снайпер"; break;
                case '2': player1 = new Paladin(); p1Person = "Паладин"; break;
                case '3': player1 = new Druid(); p1Person = "Друид"; break;
                case '4': player1 = new Warrior(); p1Person = "Воин"; break;
                case '5': player1 = new Mag(); p1Person = "Маг"; break;
            }



            Console.WriteLine("Игрок 2, выберите персонажа, которым хотите играть:");
            Console.WriteLine("1 - Снайпер");
            Console.WriteLine("2 - Паладин");
            Console.WriteLine("3 - Друид");
            Console.WriteLine("4 - Воин");
            Console.WriteLine("5 - Маг");
            key = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (key)
            {
                case '1': player2 = new Sniper(); p2Person = "Снайпер"; break;
                case '2': player2 = new Paladin(); p2Person = "Паладин"; break;
                case '3': player2 = new Druid(); p2Person = "Друид"; break;
                case '4': player2 = new Warrior(); p2Person = "Воин"; break;
                case '5': player2 = new Mag(); p2Person = "Маг"; break;
            }

            int healthcopy = player1.health;
            int healthcopy2 = player2.health;
            Console.WriteLine("Определяем, кто ходит первым...");
            countPlayer = rand.Next(0, 2);
            Console.WriteLine(countPlayer);
            if (countPlayer == 0)
            {

                Console.WriteLine("Первым ходит {0}", p1Person);

            }
            else
            {
                Console.WriteLine("Первым ходит {0}", p2Person);
            }
            Console.WriteLine("");
            while (true)
            {
                string countPConvert;
                if (countPlayer == 0) { countPConvert = p1Person; }
                else { countPConvert = p2Person; }
                if (countPlayer == 0) { Console.WriteLine("Ходит игрок {0}", p1Person); }
                else { Console.WriteLine("Ходит игрок {0}", p2Person); }
                Console.WriteLine("Для атаки нажмите 1, чтобы использовать хил 2, для пропуска хода нажмите любую другую клавишу");
                key = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                switch (key)
                {
                    case '1':
                        if (countPlayer == 0)
                        {
                            player1.Atack(player2);
                            Console.WriteLine("{0} атакует {1}", p1Person, p2Person);//1 -2
                        }
                        else
                        {
                            player2.Atack(player1);
                            Console.WriteLine("{0} атакует {1}", p2Person, p1Person); //2 -1

                        }
                        break;
                    case '2':

                        if (countPlayer == 0)
                        {
                            if ((player1.health + player1.heal) <= healthcopy)
                            {
                                player1.Heal(player1);
                                Console.WriteLine("Здоровье игрока {0} повышено", p1Person);
                            }
                            if ((player1.health + player1.heal) > healthcopy)
                            {
                                player1.health = (player1.health + player1.heal) - ((player1.health + player1.heal) - healthcopy2);
                                Console.WriteLine("Здоровье игрока {0} восстановлено до максимума", p1Person);
                            }
                        }
                        else
                        {
                            if ((player2.health + player2.heal) < healthcopy2)
                            {
                                player2.Heal(player2);
                                Console.WriteLine("Здоровье игрока {0} повышено", p2Person);
                            }
                            if ((player2.health + player2.heal) > healthcopy2)
                            {
                                player2.health = (player2.health + player2.heal) - ((player2.health + player2.heal) - healthcopy2);
                                Console.WriteLine("Здоровье игрока {0} восстановлено до максимума", p2Person);
                            }
                        }
                        break;
                    default: Console.WriteLine("Игрок {0} пропустил ход", countPConvert); break;
                }
                Console.WriteLine("Здоровье игрока {0}: {1}", p1Person, player1.health);
                Console.WriteLine("Здоровье игрока {0}: {1}", p2Person, player2.health);
                if (player1.health <= 0 || player2.health <= 0)
                {
                    Console.WriteLine("Игрок {0} победил", countPConvert);
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
                }
                if (countPlayer == 0)
                {
                    countPlayer = 1;
                }
                else

                {
                    countPlayer = 0;
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Начать заного - нажмите 1, Выйти - любую клавишу");
            key = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (key)
            {
                case '1': goto MainReCharge;
                default: Environment.Exit(1); break;
            }
            Console.ReadKey();
        }


    }
}
