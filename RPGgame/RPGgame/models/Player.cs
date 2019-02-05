using System;

namespace Model
{
    class Player
    {
        private int healthpoints = 0;

        public string name { get; set; }
        public string lastName { get; set; }
        public int healthPoints { get { return healthpoints; } set { healthpoints = value; } }
        public int attackPoints { get; set; }
    }
}
