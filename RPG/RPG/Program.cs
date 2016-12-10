using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    class Program
    {
        
        public static void Main(string[] args)
        {
            Char key; 
            int countPlayer = 0;
            Human[] firstTeam = new Human[3];
            firstTeam[0] = new Mag();
            firstTeam[1] = new Warrior();
            firstTeam[2] = new Druid();
            Human[] secondTeam = new Human[3];
            secondTeam[0] = new Mag();
            secondTeam[1] = new Warrior();
            secondTeam[2] = new Druid();
            Console.WriteLine("И так, игра почти готова. Бой вот вот начнётся. Нажмите Enter продолжения");
            Console.WriteLine("Первым будет ходить игрок, выбранный случайно");
            Random rand = new Random();
            countPlayer = rand.Next(1, 3);
            Console.WriteLine("Первым ходит игрок номер "+countPlayer);
            
            while (true)
            {
                int round=1;
                Console.WriteLine("Раунд {0}",round);
                Human activePers = firstTeam[0];
                if (countPlayer == 1)
                {
                    
                    Console.WriteLine("Выберите персонажа");
                    Console.WriteLine("1) " + firstTeam[0].WhoIAm());
                    Console.WriteLine("2) " + firstTeam[1].WhoIAm());
                    Console.WriteLine("3) " + firstTeam[2].WhoIAm());

                    key =Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1: activePers = firstTeam[0]; break;
                        case 2: activePers = firstTeam[1]; break;
                        case 3: activePers = firstTeam[2]; break;
                    }
                }
                if (countPlayer != 1)
                {
                    Console.WriteLine("Выберите персонажа");
                    Console.WriteLine("1) " + secondTeam[0].WhoIAm());
                    Console.WriteLine("2) " + secondTeam[1].WhoIAm());
                    Console.WriteLine("3) " + secondTeam[2].WhoIAm());

                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1: activePers = secondTeam[0]; break;
                        case 2: activePers = secondTeam[1]; break;
                        case 3: activePers = secondTeam[2]; break;
                    }
                }
                
                if (activePers == firstTeam[0])
                {
                    Console.WriteLine("Ходит первый игрок");
                    Console.WriteLine("Выберите, кого атаковать из команды врага:");
                    Console.WriteLine("1) " + secondTeam[0].WhoIAm());
                    Console.WriteLine("2) " + secondTeam[1].WhoIAm());
                    Console.WriteLine("3) " + secondTeam[2].WhoIAm());
                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1:firstTeam[0].Atack(secondTeam[0]); Console.WriteLine("Здоровье {0} из второй команды {1}", secondTeam[0].WhoIAm(), secondTeam[0].GetHealth()); secondTeam[0].backAtack(firstTeam[0]); break;
                        case 2: firstTeam[0].Atack(secondTeam[1]); Console.WriteLine("Здоровье {0} из второй команды {0}", secondTeam[1].WhoIAm(), secondTeam[1].GetHealth()); secondTeam[1].backAtack(firstTeam[0]); break;
                        case 3: firstTeam[0].Atack(secondTeam[2]); Console.WriteLine("Здоровье {0} из второй команды {0}", secondTeam[2].WhoIAm(), secondTeam[2].GetHealth()); secondTeam[2].backAtack(firstTeam[0]); break;
                    }
                    Console.WriteLine("Здоровье Мага из первой команды {0}", firstTeam[0].GetHealth());
                }
                if (activePers == firstTeam[1])
                {
                    Console.WriteLine("Ходит первый игрок");
                    Console.WriteLine("Выберите, кого атаковать из команды врага:");
                    Console.WriteLine("1) " + secondTeam[0].WhoIAm());
                    Console.WriteLine("2) " + secondTeam[1].WhoIAm());
                    Console.WriteLine("3) " + secondTeam[2].WhoIAm());
                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1: firstTeam[1].Atack(secondTeam[0]); Console.WriteLine("Здоровье {0} из второй команды {1}", secondTeam[0].WhoIAm(), secondTeam[0].GetHealth()); secondTeam[0].backAtack(firstTeam[1]); break;
                        case 2: firstTeam[1].Atack(secondTeam[1]); Console.WriteLine("Здоровье {0} из второй команды {1}", secondTeam[1].WhoIAm(), secondTeam[1].GetHealth()); secondTeam[1].backAtack(firstTeam[1]); break;
                        case 3: firstTeam[1].Atack(secondTeam[2]); Console.WriteLine("Здоровье {0} из второй команды {1}", secondTeam[2].WhoIAm(), secondTeam[2].GetHealth()); secondTeam[2].backAtack(firstTeam[1]); break;
                    }
                    Console.WriteLine("Здоровье Воина из первой команды {0}", firstTeam[1].GetHealth());
                }
                if (activePers == secondTeam[0])
                {
                    Console.WriteLine("Ходит второй игрок");
                    Console.WriteLine("Выберите, кого атаковать из команды врага:");
                    Console.WriteLine("1) " + firstTeam[0].WhoIAm());
                    Console.WriteLine("2) " + firstTeam[1].WhoIAm());
                    Console.WriteLine("3) " + firstTeam[2].WhoIAm());
                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1: secondTeam[0].Atack(firstTeam[0]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[0].WhoIAm(), firstTeam[0].GetHealth()); firstTeam[0].backAtack(secondTeam[0]); break;
                        case 2: secondTeam[0].Atack(firstTeam[1]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[1].WhoIAm(), firstTeam[1].GetHealth()); firstTeam[1].backAtack(secondTeam[0]); break;
                        case 3: secondTeam[0].Atack(firstTeam[2]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[2].WhoIAm(), firstTeam[2].GetHealth()); firstTeam[2].backAtack(secondTeam[0]); break;
                    }
                    Console.WriteLine("Здоровье Мага из второй команды {0}", secondTeam[0].GetHealth());
                }
                if (activePers == secondTeam[1])
                {
                    Console.WriteLine("Ходит второй игрок");
                    Console.WriteLine("Выберите, кого атаковать из команды врага:");
                    Console.WriteLine("1) " + firstTeam[0].WhoIAm());
                    Console.WriteLine("2) " + firstTeam[1].WhoIAm());
                    Console.WriteLine("3) " + firstTeam[2].WhoIAm());
                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1: secondTeam[1].Atack(firstTeam[0]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[0].WhoIAm(), firstTeam[0].GetHealth()); firstTeam[0].backAtack(secondTeam[1]); break;
                        case 2: secondTeam[1].Atack(firstTeam[1]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[1].WhoIAm(), firstTeam[1].GetHealth()); firstTeam[1].backAtack(secondTeam[1]); break;
                        case 3: secondTeam[1].Atack(firstTeam[2]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[2].WhoIAm(), firstTeam[2].GetHealth()); firstTeam[2].backAtack(secondTeam[1]); break;
                    }
                    Console.WriteLine("Здоровье Воина из второй команды {0}", secondTeam[1].GetHealth());
                }
                if (activePers == firstTeam[2])
                {
                    Console.WriteLine("Ходит первый игрок");
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1) Лечить союзника");
                    Console.WriteLine("2) Атаковать врага");
                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1:
                            Console.WriteLine("Кого вылечить?");
                            Console.WriteLine("1) Маг");
                            Console.WriteLine("2) Воин");
                            key = Console.ReadKey().KeyChar;
                            switch (int.Parse(key.ToString()))
                            {
                                case 1: firstTeam[2].Health(firstTeam[0]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[0].WhoIAm(), firstTeam[0].GetHealth()); break;
                                case 2: firstTeam[2].Health(firstTeam[1]); Console.WriteLine("Здоровье {0} из первой команды {1}", firstTeam[1].WhoIAm(), firstTeam[1].GetHealth()); break;
                            }
                            break;
                        case 2:
                    
                    Console.WriteLine("Выберите, кого атаковать из команды врага:");
                    Console.WriteLine("1) " + firstTeam[0].WhoIAm());
                    Console.WriteLine("2) " + firstTeam[1].WhoIAm());
                    Console.WriteLine("3) " + firstTeam[2].WhoIAm());
                            key = Console.ReadKey().KeyChar;
                            switch (int.Parse(key.ToString()))
                            {
                        case 1: firstTeam[2].Atack(firstTeam[0]); Console.WriteLine("Здоровье {0} из второй команды {1}", firstTeam[0].WhoIAm(), firstTeam[0].GetHealth()); break;
                        case 2: firstTeam[2].Atack(firstTeam[1]); Console.WriteLine("Здоровье {0} из второй команды {1}", firstTeam[1].WhoIAm(), firstTeam[1].GetHealth()); break;
                        case 3: firstTeam[2].Atack(firstTeam[2]); Console.WriteLine("Здоровье {0} из второй команды {1}", firstTeam[2].WhoIAm(), firstTeam[2].GetHealth()); break;
                    }
                            break;
                }
                }
                if (activePers == secondTeam[2])
                {
                    Console.WriteLine("Ходит второй игрок");
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1) Лечить союзника");
                    Console.WriteLine("2) Атаковать врага");
                    key = Console.ReadKey().KeyChar;
                    switch (int.Parse(key.ToString()))
                    {
                        case 1:
                            Console.WriteLine("Кого вылечить?");
                            Console.WriteLine("1) Маг");
                            Console.WriteLine("2) Воин");
                            key = Console.ReadKey().KeyChar;
                            switch (int.Parse(key.ToString()))
                            {
                                case 1: secondTeam[2].Health(secondTeam[0]); Console.WriteLine("Здоровье {0} из второй команды {1}", secondTeam[0].WhoIAm(), secondTeam[0].GetHealth()); break;
                                case 2: secondTeam[2].Health(secondTeam[1]); Console.WriteLine("Здоровье {0} из второй команды {1}", secondTeam[1].WhoIAm(), secondTeam[1].GetHealth()); break;
                            }
                            break;
                        case 2:

                            Console.WriteLine("Выберите, кого атаковать из команды врага:");
                            Console.WriteLine("1) " + firstTeam[0].WhoIAm());
                            Console.WriteLine("2) " + firstTeam[1].WhoIAm());
                            Console.WriteLine("3) " + firstTeam[2].WhoIAm());
                            key = Console.ReadKey().KeyChar;
                            switch (int.Parse(key.ToString()))
                            {
                                case 1: secondTeam[2].Atack(firstTeam[0]); Console.WriteLine("Здоровье {0} из первой команды {1}", secondTeam[0].WhoIAm(), firstTeam[0].GetHealth()); break;
                                case 2: secondTeam[2].Atack(firstTeam[1]); Console.WriteLine("Здоровье {0} из первой команды {1}", secondTeam[1].WhoIAm(), firstTeam[1].GetHealth()); break;
                                case 3: secondTeam[2].Atack(firstTeam[2]); Console.WriteLine("Здоровье {0} из первой команды {1}", secondTeam[2].WhoIAm(), firstTeam[2].GetHealth()); break;
                            }
                            break;
                    }

                }
                Console.WriteLine("Итог:");
                if(firstTeam[0].GetHealth()<=0)
                {
                    Console.WriteLine(firstTeam[0].WhoIAm()+"погиб");
                }
                if (firstTeam[1].GetHealth() <= 0)
                {
                    Console.WriteLine(firstTeam[1].WhoIAm() + "погиб");
                }
                if (firstTeam[2].GetHealth() <= 0)
                {
                    Console.WriteLine(firstTeam[2].WhoIAm() + "погиб");
                }
                if (secondTeam[0].GetHealth() <= 0)
                {
                    Console.WriteLine(secondTeam[0].WhoIAm() + "погиб");
                }
                if (secondTeam[1].GetHealth() <= 0)
                {
                    Console.WriteLine(secondTeam[1].WhoIAm() + "погиб");
                }
                if (secondTeam[2].GetHealth() <= 0)
                {
                    Console.WriteLine(secondTeam[2].WhoIAm() + "погиб");
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                key = Console.ReadKey().KeyChar;
                round++;
                if((firstTeam[0].GetHealth()+ firstTeam[1].GetHealth()+ firstTeam[2].GetHealth()) <= 0)
                {
                    Console.WriteLine("Игрок 1 проиграл");
                    Console.WriteLine("Игрок 2 выиграл со счётом {0}", secondTeam[0].GetHealth() + secondTeam[1].GetHealth() + secondTeam[2].GetHealth());
                    break;
                }
                if ((secondTeam[0].GetHealth() + secondTeam[1].GetHealth() + secondTeam[2].GetHealth()) <= 0)
                {
                    Console.WriteLine("Игрок 2 проиграл");
                    Console.WriteLine("Игрок 1 выиграл со счётом {0}", firstTeam[0].GetHealth() + firstTeam[1].GetHealth() + firstTeam[2].GetHealth());
                    break;
                }
            }
            Console.ReadKey();
        }


    }
}
