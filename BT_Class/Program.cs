﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameController();
            game.Game();

            Console.ReadLine();
        }
        
    }
}
