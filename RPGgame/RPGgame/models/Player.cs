using System;

namespace Model
{
    class Player
    {
        string name { get; set; }
        string lastName { get; set; }
        int healtPoints { get; set; }

        public Player(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public void playTheGame()
        {
            healtPoints = 10;
            Console.WriteLine(string.Format("{0} van de familie: {1} is begonnen met de game.", name, lastName));
        }
    }
}
