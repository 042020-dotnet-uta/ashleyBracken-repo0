using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
	class CompareResults
    {
        #region Variables
        private Game game = new Game();
        private int win;
        public int Win { get => win; set => win = value; }
        public Round curRound= new Round();
        private int p1Win = 0; // win count for player 1
        public int player1Win { get => p1Win; set => p1Win = value; }
        public int player2Win { get => p2Win; set => p2Win = value; }
        private int p2Win = 0; // win count for player 2
        #endregion
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
                    p2Win++;
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
    }
}
