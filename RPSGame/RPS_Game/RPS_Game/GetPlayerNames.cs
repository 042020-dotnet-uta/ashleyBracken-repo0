using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
     class GetPlayerNames
    {
        private Player player1 = new Player();
        private Player player2 = new Player();
        private Game game = new Game();
        private string player;
      public void GetNames()
        {
            Console.WriteLine("Enter Player 1 Name");
            player = Console.ReadLine();
            player1.Name = player;
            Console.WriteLine("Enter Player 2 Name");
            player = Console.ReadLine();
            player2.Name = player;

        }
    }
}
