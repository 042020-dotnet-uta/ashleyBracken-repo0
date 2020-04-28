using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
    class GamePlay
    {
        #region Variable declarations/Getters Setter
        private int win;
        private int p1Rand;
        private int p2Rand;
        internal Game game = new Game();
        private string[] rockPaperScis = { "rock", "paper", "scissors" };
        Random rand = new Random();
        private Round curRound;
        private GetPlayerNames getNames;
        private int p1Win = 0; // win count for player 1
        public int player1Win { get => p1Win; set => p1Win = value; }
        public int player2Win { get => p2Win; set => p2Win = value; }
        private int p2Win = 0; // win count for player 2

        #endregion
        #region RunGame
        internal void RunGame()
        {
            getNames = new GetPlayerNames(game);
           // CompareResults compare = new CompareResults();

            getNames.GetNames();
            while (player1Win < 2 && player2Win < 2)
            {
                curRound = new Round();
                p1Rand = rand.Next(3);
                p2Rand = rand.Next(3);
                win = p1Rand - p2Rand + 2;
                this.Compare();
                curRound.p1Choice = rockPaperScis[p1Rand];
                curRound.p2Choice = rockPaperScis[p2Rand];
                game.rounds.Add(curRound);
            }
            #endregion
            #region  Check Who won and print
            if (player1Win == 2|| player2Win == 2)
            {
                foreach (Round rnd in game.rounds)
                {
                    if (rnd.Winner != null)
                    {
                        Console.WriteLine(rnd.p1Choice + "  "+ rnd.p2Choice + "  "  +  rnd.Winner.Name);
                    }
                    else
                    { 
                        Console.WriteLine("There was a tie");
                        Console.WriteLine(player1Win + " " + player2Win);
                    }
                }
                if (player1Win >= 2)
                {
                    Console.WriteLine("The overall winner was" + game.p1.Name);
                }
                else Console.WriteLine("The Overall winner was" + game.p2.Name);
            }
            #endregion 
        }
        #region Switch for comparing
        internal void Compare()
        {

            switch (win)
            { //win is mostly unique varying with what each player picks
                case 0: //p1 rock p2 scissor p1 wins
                    curRound.Winner = game.p1;
                    p1Win++;
                    break;
                case 1: // p1 lost since result is negative rock(0) - paper(1) or 1 - 2
                    curRound.Winner = game.p2;
                    p2Win++;
                    break;
                case 2: // tie
                    curRound.Winner = null;
                    break;
                case 3:// p1 wins as 1 - 0 or 2 - 1;
                    curRound.Winner = game.p1;
                    p1Win++;
                    break;
                case 4://p1 scissor p2 rock p2 wins
                    curRound.Winner = game.p2;
                    p2Win++;
                    break;
                default:
                    break;
            }

            return;
        }
        #endregion

    }
}