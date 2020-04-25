using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RPS_Game
{
    class Program

    {
        // Main Method, Entry point, where the program begins
        static void Main()
        {
            GamePlay gamePlay = new GamePlay();
            Game game = new Game();
            gamePlay.RunGame();
        }
    }
}