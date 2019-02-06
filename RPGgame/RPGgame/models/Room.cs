using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class Room
    {
        public string roomName { get; set; }
        public string description { get; set; }
        public Boolean hasMonster { get; set; } = false;
        public Boolean hasTreasure { get; set; } = false;

        public Room NorthConnection = null;
        public Room EastConnection = null;
        public Room SouthConnection = null;
        public Room WestConnection = null;

        public Room (string roomName, string description, Boolean hasMonster, Boolean hasTreasure)
        {
            this.roomName = roomName;
            this.description = description;
            this.hasMonster = hasMonster;
            this.hasTreasure = hasTreasure;
        }
    }
}
