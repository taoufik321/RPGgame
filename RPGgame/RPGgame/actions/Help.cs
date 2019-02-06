using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.models
{
    class Help
    {
        public void printHelp()
        {
            Console.WriteLine(@"
                                   ______________________________
                                 / \                             \.
                                |   |  * type 'attack' to: attack|.
                                 \_ |    the enemy               |.
                                    |                            |.
                                    |  * type 'walk north' to    |.
                                    |    to the room north of you|.
                                    |                            |.
                                    |  * type 'walk west' to     |.
                                    |    to the room west of you |.
                                    |                            |.
                                    |  * type 'walk south' to    |.
                                    |    to the room south of you|.
                                    |                            |.
                                    |  * type 'walk east' to     |.
                                    |    to the room wast of you |.
                                    |                            |.
                                    |  * type 'stop' to          |.
                                    |    to stop the game        |.
                                    |                            |.
                                    |  * type 'exit' to          |.
                                    |    to stop the game        |.
                                    |                            |.
                                    |  * type 'suicide' to       |.
                                    |    to stop the game        |.
                                    |                            |.
                                    |  * type 'end game' to      |.
                                    |    to stop the game        |.
                                    |                            |.
                                    |  * type 'quit' to          |.
                                    |    to stop the game        |.
                                    |                            |.
                                    |   _________________________|___
                                    |  /                            /.
                                    \_/____________________________/.
            ");
        }
    }
}
