using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class CommandHelper
    {
        Enemy enemy = new Enemy();

        public void getCommand()
        {
            string command = Console.ReadLine();

            string action = command.ToLower();

            // string[] action = command.Split(" ");

            switch(action)
            {
                case "attack":
                    Console.WriteLine("The player choose to: attack");
                    break;
                case "walk":
                    Console.WriteLine("The player choose to: walk");
                    enemy.getEnemy();
                    break;
                case "stop":
                case "exit":
                case "suicide":
                case "end game":
                    Console.WriteLine("The player choose to: commit suicide");
                    Game.stop();
                    break;
                case "help":
                    Console.WriteLine("The player choose to: ask for help!");
                    break;
               default:
                    Console.WriteLine("This command is not valid, type 'help' to see all the valids commands.");
                    break;
            }

            if(action != "stop" || action != "exit" || action != "suicide" || action != "end game")
            {
                getCommand();
            }
        }
    }
}