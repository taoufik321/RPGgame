﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class Game
    {
        public void start()
        {
            Console.SetWindowSize(140, 30);

            Console.WriteLine(@"
                                                                    __  __  __
                                                                   /  \/  \/  \
                                                                  / /\/ /\/ /\ \
                                                                  \ \/ /\/ /\/ /
                                                                   \ \/\ \/\ \/
                                                                   /\ \/\ \/\ \
                                                                  / /\/ /\/ /\ \
                                                                 / / / /\/ /\ \ \
                                                                 \ \/ /\ \/\ \/ /
                                                                  \ \/ /\ \ \ \/
                                                                  /\ \/ /\ \/\ \
                                                                 / /\/ /()\/ /\ \
                                                                 \ \/ /\  / /\/ /
                                                           __  __ \ \/\ \/ /\ \/ __  __
                                                      __  /  \/  \/\ \/ /\ \/\ \/  \/  \  __
                                                     /  \/ /\/ /\/ /\/ /()\/ /\/ /\/ /\ \/  \
                                                    / /\/ / / /\/ /\/ /\  / /\/ /\/ /\ \/ /\ \
                                                    \ \/ /\/ /\ \/\ \/\ \/ /\ \/\ \/\ \/ /\/ /
                                                     \ \/\ \/ /\ \/\ \ \ \/ /\ \/\ \ \ \/\ \/
                                                     /\ \/\ \/ /\__/\ \/\ \/ /\__/\ \/\ \/\ \
                                                    / /\/ /\/ / |_)/`\/ /\/ /  ()  \/ /\/ /\ \
                                                    \ \/ /\/ /\ |__\7/ /\/ /\  __  / /\/ /\/ /
                                                     \ \/\ \/\ \/  \/ /\ \/\ \/  \/ /\ \/\ \/
                                                     /\ \/\ \ \ \/\ \/ /\ \ \ \/\ \/ /\ \/\ \
                                                    / /\/ /\ \/\ \/\ \/ /\ \/\ \/\ \/ /\/ /\ \
                                                    \ \/ /\ \/ /\/ /\/ /()\/ /\/ /\/ / / /\/ /
                                                     \__/\ \/ /\/ /\/ /\  / /\/ /\/ /\/ /\__/
                                                          \__/\__/\ \/\ \/ /\ \/\__/\__/
                                                                  /\ \/ /\ \/\ \
                                                                 / /\/ /()\/ /\ \
                                                                 \ \/ /\  / /\/ /
                                                                  \ \/\ \/ /\ \/
                                                                  /\ \ \ \/ /\ \
                                                                 / /\ \/\ \/ /\ \
                                                                 \ \ \/ /\/ / / /
                                                                  \ \/ /\/ /\/ /
                                                                   \ \/\ \/\ \/
                                                                   /\ \/\ \/\ \
                                                                  / /\/ /\/ /\ \
                                                                  \ \/ /\/ /\/ /
                                                                   \__/\ \/\__/
                                                               __  /  \/\ \/  \  __
                                                          __  /  \/ /\/ /\/ /\ \/  \  __
                                                         /  \/ /\/ / / /\/ /\ \/ /\ \/  \
                                                        / /\/ / / /\/ /\ \/\ \/ /\ \/ /\ \
                                                        \ \/ /\/ /\ \/ /\ \ \ \/\ \/ /\/ /
                                                         \ \/\ \/ /\ \/ /\ \/\ \ \ \/\ \/
                                                         /\ \/\ \/ /\/ /()\/ /\ \/\ \/\ \
                                                        / /\/ /\/ / / /\  / /\ \/ /\/ /\ \
                                                        \ \/ /\/ /\/ /\ \/ /\ \/ /\/ /\/ /
                                                         \__/\__/\__/  \__/  \__/\__/\__/
            ");

            Console.WriteLine(@"
        
        ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗    ████████╗ ██████╗     ████████╗██╗  ██╗██╗███████╗          
        ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝    ╚══██╔══╝██╔═══██╗    ╚══██╔══╝██║  ██║██║██╔════╝          
        ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗         ██║   ██║   ██║       ██║   ███████║██║███████╗          
        ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝         ██║   ██║   ██║       ██║   ██╔══██║██║╚════██║          
        ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗       ██║   ╚██████╔╝       ██║   ██║  ██║██║███████║          
         ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝       ╚═╝    ╚═════╝        ╚═╝   ╚═╝  ╚═╝╚═╝╚══════╝          
                                                                                                                                                                                                                                                                  
                                                                                                                                      
         █████╗ ███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ ██████╗     ██████╗ ██████╗  ██████╗      ██████╗  █████╗ ███╗   ███╗███████╗
        ██╔══██╗████╗ ████║██╔══██╗╚══███╔╝██║████╗  ██║██╔════╝     ██╔══██╗██╔══██╗██╔════╝     ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
        ███████║██╔████╔██║███████║  ███╔╝ ██║██╔██╗ ██║██║  ███╗    ██████╔╝██████╔╝██║  ███╗    ██║  ███╗███████║██╔████╔██║█████╗  
        ██╔══██║██║╚██╔╝██║██╔══██║ ███╔╝  ██║██║╚██╗██║██║   ██║    ██╔══██╗██╔═══╝ ██║   ██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
        ██║  ██║██║ ╚═╝ ██║██║  ██║███████╗██║██║ ╚████║╚██████╔╝    ██║  ██║██║     ╚██████╔╝    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
        ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═╝╚═╝      ╚═════╝      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                                                                                      
        
            ");
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last name?:");
            string lastName = Console.ReadLine();

            Player player = new Player(name, lastName);

            player.playTheGame();

            Enemy enemy = new Enemy();

            enemy.getEnemy();

            CommandHelper commandHelper = new CommandHelper();
            commandHelper.getCommand();

            Console.ReadLine();
        }

        public static void stop()
        {
            // Exit the console
            Environment.Exit(0);
        }
    }
}
