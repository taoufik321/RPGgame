using RPGgame.actions;
using RPGgame.commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class CommandHandler
    {
        // private static PlayerHandler playerhandler = PlayerHandler.Instance;

        Commands commands = new Commands();

        RoomHandler roomHandler = new RoomHandler();

        Help help = new Help();

        public void getCommand()
        {
            string command = Console.ReadLine();

            // string action = command.ToLower();

            string[] action = command.ToLower().Split(" ");

            switch(action[0])
            {
                case "attack":
                    Console.WriteLine("The player choose to: attack");
                    Console.WriteLine("The player give {0} damage to the enemy", commands.getAttackPointsPlayer());
                    break;
                case "walk":
                    if (action.Length > 1)
                    {
                        Console.WriteLine("The player choose to: walk");
                        roomHandler.Walk(action[1]);
                    } else
                    {
                        Console.WriteLine("No valid input for the command 'walk' !");
                    }
                    break;
                case "stop":
                case "exit":
                case "suicide":
                case "end game":
                case "quit":
                    Console.WriteLine("The player choose to: end the game...");
                    Game.stop();
                    break;
                case "help":
                    Console.WriteLine("The player choose to: ask for help!");
                    help.printHelp();
                    break;
               default:
                    Console.WriteLine("This command is not valid, type 'help' to see all the valid commands.");
                    break;
            }

            if(action[0] != "stop" || action[0] != "exit" || action[0] != "suicide" || action[0] != "end game" || action[0] != "quit")
            {
                getCommand();
            }
        }   
    }
}