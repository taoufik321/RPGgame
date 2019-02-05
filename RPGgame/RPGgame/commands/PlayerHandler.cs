using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.commands
{
    public class PlayerHandler
    {
        //het soort van final object waar je altijd toegang van kan opvragen  
        private static PlayerHandler instance;

        private Player player;

        private PlayerHandler() { }

        public static PlayerHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerHandler();
                }
                return instance;
            }
        }

        public Player CreatePlayer(string name, string lastName)
        {
            player = new Player(name, lastName);
            return player;
        }

        public Player GetPlayer
        {
            get
            {
                return player;
            }
        }
    }
}
