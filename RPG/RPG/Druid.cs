﻿using System;
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
            health = 78;
            damage = 10;
            heal = 17;
            //1326
        }
        public override void WhoIAm()
        {
            Console.WriteLine("Druid");
        }
    }
}