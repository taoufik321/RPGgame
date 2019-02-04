using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class Enemy
    {
        int attackPoints { get; set; }

        int healthPoints { get; set; }

        private EnemyType type;

        public EnemyType randomEnemy()
        {
            Array values = Enum.GetValues(typeof(EnemyType));
            Random random = new Random();
            EnemyType randomEnemy = (EnemyType)values.GetValue(random.Next(values.Length));

            return randomEnemy;
        }

        public void getEnemy()
        {
            type = randomEnemy();

            switch (type)
            {
                case EnemyType.SMALL_MONSTER:
                    healthPoints = randomNumber(1, 3);
                    attackPoints = randomNumber(1, 3);
                    Console.WriteLine("SMALL MONSTER with so much health points: {0} and can give so much damage to the player: {1}", healthPoints, attackPoints);
                    break;

                case EnemyType.MEDIUM_MONSTER:
                    healthPoints = randomNumber(4, 6);
                    attackPoints = randomNumber(4, 6);
                    Console.WriteLine("MEDIUM MONSTER with so much health points: {0} and can give so much damage to the player: {1}", healthPoints, attackPoints);
                    break;

                case EnemyType.BIG_MONSTER:
                    healthPoints = randomNumber(7, 10);
                    attackPoints = randomNumber(7, 10);
                    Console.WriteLine("BIG MONSTER with so much health points: {0} and can give so much damage to the player: {1}", healthPoints, attackPoints);
                    break;

                default:
                    Console.WriteLine("No monsters in this room :)");
                    break;

            }
        }

        private int randomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber);
        }
    }
}
