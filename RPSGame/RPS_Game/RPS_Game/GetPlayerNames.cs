using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
     class GetPlayerNames
    {
        #region variable declaration an assignment
        private Player player1 = new Player();
        private Player player2 = new Player();
        Game game;
        internal GetPlayerNames(Game game) 
        {
            this.game = game;
        }
        private string player;
        #endregion
        #region getNames method
        public void GetNames()
        {
            Console.WriteLine("Enter Player 1 Name");
            player = Console.ReadLine();
            player1.Name = player;
            Console.WriteLine("Enter Player 2 Name");
            player = Console.ReadLine();
            player2.Name = player;
            game.p1 = player1;
            game.p2 = player2;

        }
        #endregion
    }
}
