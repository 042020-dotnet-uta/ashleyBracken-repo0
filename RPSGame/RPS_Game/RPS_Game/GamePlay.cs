using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
    class GamePlay
    {
        #region Variable declarations/Getters Setter
        private int p1Rand;
        private int p2Rand;
        CompareResults compare = new CompareResults();
        Game game = new Game();
        private string[] rockPaperScis = { "rock", "paper", "scissors" };
        Random rand = new Random();
        private GetPlayerNames getNames = new GetPlayerNames();
        #endregion
        internal void RunGame()
        {

           
            getNames.GetNames();
            while (compare.player1Win < 2 && compare.player2Win < 2)
            {
                compare.curRound.p1Choice = rockPaperScis[p1Rand];
                compare.curRound.p2Choice = rockPaperScis[p2Rand];
                p1Rand = rand.Next(3);
                p2Rand = rand.Next(3);
                compare.Win = p1Rand - p2Rand + 2;
                compare.Compare();
                game.rounds.Add(compare.curRound);
            }
            

            if (compare.player1Win == 2|| compare.player2Win == 2)
            {
                foreach (Round rnd in game.rounds)
                {
                    if (rnd.Winner != null)
                    {
                        Console.WriteLine(rnd.p1Choice + rnd.p2Choice + rnd.Winner);
                    }
                    else Console.WriteLine("There is no winner");
                }
                
            }
        }
    }
}