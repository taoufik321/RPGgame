using System;

namespace Model
{
    class Player
    {
        string name { get; set; }
        string lastName { get; set; }
        int healthPoints { get; set; }
        int attackPoints { get; set; }

        Random random = new Random();

        public Player(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public void playTheGame()
        {
            healthPoints = random.Next(1, 20);
            attackPoints = random.Next(1, 10);

            Console.WriteLine(string.Format("{0} with the last name: {1} started his adventure, you got so much health points: {2}", name, lastName, healthPoints));
        }
    }
}
