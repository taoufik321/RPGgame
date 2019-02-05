using RPGgame.commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class CommandHandler
    {
        Enemy enemy = new Enemy();

        Commands commands = new Commands();

        Help help = new Help();

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

                    // Create the Enemy
                    commands.createEnemy();

                    Console.WriteLine("The health from the enemy is: {0}, and for the Player is: {1}", commands.getHealthEnemy(), commands.getHealthPlayer());

                    break;
                case "stop":
                case "exit":
                case "suicide":
                case "end game":
                case "quit":
                    Console.WriteLine("The player choose to: commit suicide");
                    Game.stop();
                    break;
                case "help":
                    Console.WriteLine("The player choose to: ask for help!");
                    help.printHelp();
                    break;
               default:
                    Console.WriteLine("This command is not valid, type 'help' to see all the valids commands.");
                    break;
            }

            if(action != "stop" || action != "exit" || action != "suicide" || action != "end game" || action != "quit")
            {
                getCommand();
            }
        }
    }
}