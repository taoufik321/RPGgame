using RPGgame.models;
using RPGgame.commands;
using RPGgame.enemy;

using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.actions
{
    class RoomHandler
    {
        Commands commands = new Commands();

        Room firstRoom = new Room("First Room", "First Description", false, false);
        Room secondRoom = new Room("Second Room", "Second Description", true, false);
        Room thirdRoom = new Room("Third Room", "Third Description", true, true);

        // internal Dictionary<Directions, Room> levelLayout = new Dictionary<Directions, Room>();

        public void initializeRooms()
        {
            Game.currentRoom = firstRoom;

            // First level layout
            firstRoom.NorthConnection = secondRoom;

            // Second level layout
            secondRoom.SouthConnection = firstRoom;
            secondRoom.WestConnection = thirdRoom;

            // Third level layout
            thirdRoom.EastConnection = secondRoom;
        }

        public void Walk(string action)
        {
            string command = action.ToLower();

            switch (command)
            {
                case "north":
                    if (Game.currentRoom.NorthConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.NorthConnection;
                        Console.WriteLine("You are now in the room: {0}, this room is: {1}", Game.currentRoom.roomName, Game.currentRoom.description);
                    }
                    else
                    {
                        Console.WriteLine("You ran into a wall. Try another direction.");
                    }
                    break;
                case "east":
                    if (Game.currentRoom.EastConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.EastConnection;
                        Console.WriteLine("You are now in the room: {0}, this room is: {1}", Game.currentRoom.roomName, Game.currentRoom.description);
                    }
                    else
                    {
                        Console.WriteLine("You ran into a wall. Try another direction.");
                    }
                    break;
                case "south":
                    if (Game.currentRoom.SouthConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.SouthConnection;
                        Console.WriteLine("You are now in the room: {0}, this room is: {1}", Game.currentRoom.roomName, Game.currentRoom.description);
                    }
                    else
                    {
                        Console.WriteLine("You ran into a wall. Try another direction.");
                    }
                    break;
                case "west":
                    if (Game.currentRoom.WestConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.WestConnection;
                        Console.WriteLine("You are now in the room: {0}, this room is: {1}", Game.currentRoom.roomName, Game.currentRoom.description);
                    }
                    else
                    {
                        Console.WriteLine("You ran into a wall. Try another direction.");
                    }
                    break;
                default:
                    Console.WriteLine("This command is not valid, type 'help' to see all the valid commands.");
                    break;
            }

            checkRoom();
        }

        public void checkRoom()
        {
            if (Game.currentRoom.hasMonster == true)
            {
                commands.createEnemy();
                Console.WriteLine("The health from the enemy is: {0}, and for the Player is: {1}", commands.getHealthEnemy(), commands.getHealthPlayer());
            }
            else
            {
                EnemyCharacterModel.noEnemy();
                Console.WriteLine("No enemies found in this room, navigate through the cave to find your treasure.");
            }

            if (Game.currentRoom.hasTreasure == true)
            {
                commands.foundTreasure();
            }
        }
    }
}
