using Model;
using RPGgame.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.commands
{
    class Commands
    {
        private static PlayerHandler playerhandler = PlayerHandler.Instance;

        Enemy enemy = new Enemy();

        Random random = new Random();

        private EnemyType type;

        private int playerHealthpoints;

        // *** Player Creation ***
        public void createPlayer()
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last name?:");
            string lastName = Console.ReadLine();

            playerHealthpoints = random.Next(1, 20);

            playerhandler.CreatePlayer(name, lastName);

            // player.healthPoints = playerHealthpoints;

            // player.attackPoints = random.Next(1, 10);

            Console.WriteLine(string.Format("{0} with the last name: {1} started his adventure, you got so much health points: {2}", playerhandler.GetPlayer.name, playerhandler.GetPlayer.lastName, playerhandler.GetPlayer.healthPoints));
        }

        public int getHealthPlayer()
        {
            return playerhandler.GetPlayer.healthPoints;
        }

        public int getHealthEnemy()
        {
            return enemy.healthPoints;
        }

        // *** Enemy Creation ***
        public void createEnemy()
        {
            type = randomEnemy();

            switch (type)
            {
                case EnemyType.SMALL_MONSTER:
                    enemy.healthPoints = randomNumber(1, 3);
                    enemy.attackPoints = randomNumber(1, 3);
                    EnemyCharacterModel.small();

                    Console.WriteLine("SMALL MONSTER with so much health points: {0} and can give so much damage to the player: {1}", enemy.healthPoints, enemy.attackPoints);
                    break;

                case EnemyType.MEDIUM_MONSTER:
                    enemy.healthPoints = randomNumber(4, 6);
                    enemy.attackPoints = randomNumber(4, 6);
                    EnemyCharacterModel.medium();

                    Console.WriteLine("MEDIUM MONSTER with so much health points: {0} and can give so much damage to the player: {1}", enemy.healthPoints, enemy.attackPoints);
                    break;

                case EnemyType.BIG_MONSTER:
                    enemy.healthPoints = randomNumber(7, 10);
                    enemy.attackPoints = randomNumber(7, 10);
                    EnemyCharacterModel.big();

                    Console.WriteLine("BIG MONSTER with so much health points: {0} and can give so much damage to the player: {1}", enemy.healthPoints, enemy.attackPoints);
                    break;

                default:
                    Console.WriteLine("No monsters in this room :)");
                    break;
            }
        }

        public EnemyType randomEnemy()
        {
            Array values = Enum.GetValues(typeof(EnemyType));
            Random random = new Random();
            EnemyType randomEnemy = (EnemyType)values.GetValue(random.Next(values.Length));

            return randomEnemy;
        }

        private int randomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber);
        }

    }
}
