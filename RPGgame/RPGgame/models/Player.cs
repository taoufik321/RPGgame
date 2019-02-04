using System;
using System.Collections.Generic;
using System.Text;

namespace Maandag.Model
{
    class Player
    {
        string name { get; set; }
        string lastName { get; set; }

        public Player(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public void playTheGame()
        {
            Console.WriteLine(name + " van de familie: " + lastName + " is begonnen met de game.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last name?:");
            string lastName = Console.ReadLine();

            Player player = new Player(name, lastName);
            player.playTheGame();

            Console.ReadLine();

            //var userInput = Console.ReadLine();

            //string naam = "Taoufik";
            //string stringetje = string.Format("Hallo {0}", naam);

            //string nieuweStringetje = stringetje + " " + naam;

            //string fileName1 = "c:\\documents\\test.txt";
            //string fileName2 = @"c:\documents\test.txt";

            //Console.WriteLine("Hello World!");
        }
    }
}
