using RPGgame.models;
using System;

namespace Model
{
    public class Player
    {
        public string name { get; private set; }
        public string lastName { get; private set; }
        public int healthPoints { get; set; } = 250;
        public int attackPoints { get; set; }

        public Player(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
    }
}
