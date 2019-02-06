using RPGgame.models;
using RPGgame.enemy;
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

        // *** Player Creation ***
        public void createPlayer()
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last name?:");
            string lastName = Console.ReadLine();

            playerhandler.CreatePlayer(name, lastName);

            playerhandler.GetPlayer.attackPoints = random.Next(1, 10);

            Console.WriteLine(string.Format("{0} with the last name: {1} started his adventure, you got so much health points: {2}, and your attack points are: {3} points", playerhandler.GetPlayer.name, playerhandler.GetPlayer.lastName, playerhandler.GetPlayer.healthPoints, playerhandler.GetPlayer.attackPoints));
        }

        public int getHealthPlayer()
        {
            return playerhandler.GetPlayer.healthPoints;
        }

        public int getAttackPointsPlayer()
        {
            return playerhandler.GetPlayer.attackPoints;
        }

        public int getHealthEnemy()
        {
            return enemy.healthPoints;
        }

        public void gameOver()
        {
            Console.WriteLine(@"
                                           ,--.
                                          {    }
                                          K,   }
                                         /  `Y`
                                    _   /   /
                                   {_'-K.__/
                                     `/-.__L._
                                     /  ' /`\_}
                                    /  ' /     
                            ____   /  ' /
                     ,-'~~~~    ~~/  ' /_
                   ,'             ``~~~%%',
                  (                     %  Y
                 {                      %% I
                {      -                 %  `.
                |       ',                %  )
                |        |   ,..__      __. Y
                |    .,_./  Y ' / ^Y   J   )|
                \           |' /   |   |   ||
                \          L_/    . _ (_,.'(
                 \,   ,      ^^""' / |      )
                   \_  \          /,L]     /
                      '-_`-,       ` `   ./`
                         `-(_            )
                             ^^\..___,.--`
            ");

            Console.WriteLine("You died...");

            Console.WriteLine("Type 'exit' to exit the game.");
        }

        public void foundTreasure()
        {
            Console.WriteLine(@"
                                        _.--.
                                    _.-'_:-'||
                                _.-'_.-::::'||
                           _.-:'_.-::::::'  ||
                         .'`-.-:::::::'     ||
                        /.'`;|:::::::'      ||_
                       ||   ||::::::'     _.;._'-._
                       ||   ||:::::'  _.-!oo @.!-._'-.
                       \'.  ||:::::.-!()oo @!()@.-'_.|
                        '.'-;|:.-'.&$@.& ()$%-'o.'\U||
                          `>'-.!@%()@'@_%-'_.-o _.|'||
                           ||-._'-.@.-'_.-' _.-o  |'||
                           ||=[ '-._.-\U/.-'    o |'||
                           || '-.]=|| |'|      o  |'||
                           ||      || |'|        _| ';
                           ||      || |'|    _.-'_.-'
                           |'-._   || |'|_.-'_.-'
                            '-._'-.|| |' `_.-'
                                '-.||_/.-'  
            ");

            Console.WriteLine("Congratulations you found the treasure, now you can take it and leave, you won the game!!!!");

            Console.WriteLine("Type 'exit' to exit the game.");
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
