using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    class Program : PlayerData
    {
        
        public static void Main(string[] args)
        {
            int countPlayer = 0;
            Human[] firstTeam = new Human[2];
            firstTeam[0] = new Mag();
            firstTeam[1] = new Warrior();
            firstTeam[2] = new Druid();
            Human[] secondTeam = new Human[2];
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
                if (countPlayer == 1)
                        {
                    Console.WriteLine("Выберите персонажа");
                    Console.WriteLine("1) " + firstTeam[0].WhoIAm());
                    Console.WriteLine("2) " + firstTeam[1].WhoIAm());
                    Console.WriteLine("3) " + firstTeam[2].WhoIAm());
                    int answer = int.Parse(Console.ReadLine());
                    Human activePers = firstTeam[0];
                    switch (answer)
                    {
                        case 1: activePers = firstTeam[0];break;
                        case 2: activePers = firstTeam[1]; break;
                        case 3: activePers = firstTeam[2]; break;
                    }
                }
            }
            Console.ReadKey();
        }


    }
}
