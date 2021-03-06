﻿using RPGgame.commands;
using RPGgame.actions;
using RPGgame.enemy;

using System;
using System.Collections.Generic;
using System.Text;


using System.Diagnostics;

namespace RPGgame.models
{
    class Game
    {
        Commands commands = new Commands();

        public static Room currentRoom;

        static Stopwatch stopWatch = new Stopwatch();
        
        public void start()
        {
            stopWatch.Start();

            Console.SetWindowSize(140, 30);

            printWelcomeScreen();

            // Initialize levels
            RoomHandler gameLevels = new RoomHandler();
            gameLevels.initializeRooms();

            // Create the Player
            commands.createPlayer();

            if (Game.currentRoom.hasMonster == false)
            {
                EnemyCharacterModel.noEnemy();
                Console.WriteLine("No enemies found in this room, navigate through the cave to find your treasure.");
            }

            CommandHandler commandHandler = new CommandHandler();
            commandHandler.getCommand();

            Console.ReadLine();
        }

        public static void stop()
        {
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine("The time you have spent in this game: {0} ", elapsedTime);
            Console.ReadLine();

            // Exit the console
            Environment.Exit(0);
        }

        public void printWelcomeScreen()
        {
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

            Console.WriteLine(@"
        
                                    ╦ ╦┌─┐┬ ┬  ┌─┐┬─┐┌─┐  ┌┬┐┬─┐┌─┐┌─┐┌─┐┌─┐┌┬┐  ┬┌┐┌  ┌─┐  ┌─┐┌─┐┬  ┬┌─┐                           
                                    ╚╦╝│ ││ │  ├─┤├┬┘├┤    │ ├┬┘├─┤├─┘├─┘├┤  ││  ││││  ├─┤  │  ├─┤└┐┌┘├┤                            
                                     ╩ └─┘└─┘  ┴ ┴┴└─└─┘   ┴ ┴└─┴ ┴┴  ┴  └─┘─┴┘  ┴┘└┘  ┴ ┴  └─┘┴ ┴ └┘ └─┘┘                          
                           ┬ ┬┌─┐┬ ┬┬─┐  ┌─┐┌─┐┌─┐┬    ┬┌─┐  ┌┬┐┌─┐  ┌─┐┬┌┐┌┌┬┐  ┌┬┐┬ ┬┌─┐  ┌┬┐┬─┐┌─┐┌─┐┌─┐┬ ┬┬─┐┌─┐       
                           └┬┘│ ││ │├┬┘  │ ┬│ │├─┤│    │└─┐   │ │ │  ├┤ ││││ ││   │ ├─┤├┤    │ ├┬┘├┤ ├─┤└─┐│ │├┬┘├┤        
                            ┴ └─┘└─┘┴└─  └─┘└─┘┴ ┴┴─┘  ┴└─┘   ┴ └─┘  └  ┴┘└┘─┴┘   ┴ ┴ ┴└─┘   ┴ ┴└─└─┘┴ ┴└─┘└─┘┴└─└─┘o      
                                                                                                
                                                                                                
                                        ╔╦╗┌─┐  ┌─┐┬┌┐┌┌┬┐  ┌┬┐┬ ┬┌─┐  ┌┬┐┬─┐┌─┐┌─┐┌─┐┬ ┬┬─┐┌─┐  ┬ ┬┌─┐┬ ┬                              
                                         ║ │ │  ├┤ ││││ ││   │ ├─┤├┤    │ ├┬┘├┤ ├─┤└─┐│ │├┬┘├┤   └┬┘│ ││ │                              
                                         ╩ └─┘  └  ┴┘└┘─┴┘   ┴ ┴ ┴└─┘   ┴ ┴└─└─┘┴ ┴└─┘└─┘┴└─└─┘   ┴ └─┘└─┘                              
                           ┌┐┌┌─┐┌─┐┌┬┐  ┌┬┐┌─┐  ┌┐┌┌─┐┬  ┬┬┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┬ ┬┬─┐┌─┐┬ ┬┌─┐┬ ┬  ┌┬┐┬ ┬┬┌─┐  ┌─┐┌─┐┬  ┬┌─┐ 
                           │││├┤ ├┤  ││   │ │ │  │││├─┤└┐┌┘││ ┬├─┤ │ ├┤    │ ├─┤├┬┘│ ││ ││ ┬├─┤   │ ├─┤│└─┐  │  ├─┤└┐┌┘├┤  
                           ┘└┘└─┘└─┘─┴┘   ┴ └─┘  ┘└┘┴ ┴ └┘ ┴└─┘┴ ┴ ┴ └─┘   ┴ ┴ ┴┴└─└─┘└─┘└─┘┴ ┴   ┴ ┴ ┴┴└─┘  └─┘┴ ┴ └┘ └─┘o
                                
                                    
                           ╔═╗┌┐┌┌─┐┌┬┐┬┌─┐┌─┐  ┌─┐┌─┐┌┐┌  ┌┐ ┌─┐  ┌─┐┌─┐┬ ┬┌┐┌┌┬┐  ┬┌┐┌  ┌┬┐┬ ┬┬┌─┐  ┌─┐┌─┐┬  ┬┌─┐ 
                           ║╣ │││├┤ ││││├┤ └─┐  │  ├─┤│││  ├┴┐├┤   ├┤ │ ││ ││││ ││  ││││   │ ├─┤│└─┐  │  ├─┤└┐┌┘├┤  
                           ╚═╝┘└┘└─┘┴ ┴┴└─┘└─┘  └─┘┴ ┴┘└┘  └─┘└─┘  └  └─┘└─┘┘└┘─┴┘  ┴┘└┘   ┴ ┴ ┴┴└─┘  └─┘┴ ┴ └┘ └─┘┘
                                        ┌─┐┌─┐  ┬ ┬┌─┐┌┬┐┌─┐┬ ┬  ┌─┐┬ ┬┌┬┐  ┌─┐┌─┐┬─┐  ┌┬┐┬ ┬┌─┐┌┬┐┬                             
                                        └─┐│ │  │││├─┤ │ │  ├─┤  │ ││ │ │   ├┤ │ │├┬┘   │ ├─┤├┤ ││││                             
                                        └─┘└─┘  └┴┘┴ ┴ ┴ └─┘┴ ┴  └─┘└─┘ ┴   └  └─┘┴└─   ┴ ┴ ┴└─┘┴ ┴o                             

                                                                                                                                                                                    
                                ╦┌─┐  ┬ ┬┌─┐┬ ┬  ┌─┐┬┌┐┌┌┬┐  ┌┬┐┬ ┬┌─┐  ┌┬┐┬─┐┌─┐┌─┐┌─┐┬ ┬┬─┐┌─┐  ┌┬┐┬ ┬┌─┐         
                                ║├┤   └┬┘│ ││ │  ├┤ ││││ ││   │ ├─┤├┤    │ ├┬┘├┤ ├─┤└─┐│ │├┬┘├┤    │ ├─┤├┤                      
                                ╩└     ┴ └─┘└─┘  └  ┴┘└┘─┴┘   ┴ ┴ ┴└─┘   ┴ ┴└─└─┘┴ ┴└─┘└─┘┴└─└─┘   ┴ ┴ ┴└─┘     
                                ┌─┐─┐ ┬┬┌┬┐  ┌─┐┌─┐┌┬┐┬ ┬  ┬ ┬┬┬  ┬    ┌─┐┌─┐┌─┐┌┐┌  ┌─┐┌─┐┬─┐  ┬ ┬┌─┐┬ ┬          
                                ├┤ ┌┴┬┘│ │   ├─┘├─┤ │ ├─┤  │││││  │    │ │├─┘├┤ │││  ├┤ │ │├┬┘  └┬┘│ ││ │        
                                └─┘┴ └─┴ ┴   ┴  ┴ ┴ ┴ ┴ ┴  └┴┘┴┴─┘┴─┘  └─┘┴  └─┘┘└┘  └  └─┘┴└─   ┴ └─┘└─┘            
                                ┌┬┐┌─┐┌─┐┌┐┌┬┌┐┌┌─┐  ┌┬┐┬ ┬┌─┐┌┬┐  ┬ ┬┌─┐┬ ┬  ┌─┐┌─┐┌┐┌  ┌─┐┌─┐┌─┐┌─┐┌─┐┌─┐                     
                                │││├┤ ├─┤││││││││ ┬   │ ├─┤├─┤ │   └┬┘│ ││ │  │  ├─┤│││  ├┤ └─┐│  ├─┤├─┘├┤                      
                                ┴ ┴└─┘┴ ┴┘└┘┴┘└┘└─┘   ┴ ┴ ┴┴ ┴ ┴    ┴ └─┘└─┘  └─┘┴ ┴┘└┘  └─┘└─┘└─┘┴ ┴┴  └─┘          
                                            ┌┬┐┬ ┬┬┌─┐  ┌┬┐┌─┐┬─┐┬─┐┬┌┐ ┬  ┌─┐  ┌─┐┌─┐┬  ┬┌─┐                  
                                             │ ├─┤│└─┐   │ ├┤ ├┬┘├┬┘│├┴┐│  ├┤   │  ├─┤└┐┌┘├┤                    
                                             ┴ ┴ ┴┴└─┘   ┴ └─┘┴└─┴└─┴└─┘┴─┘└─┘  └─┘┴ ┴ └┘ └─┘o                    
            ");
        }
    }
}
