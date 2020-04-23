using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RPS_Game
{
    class GamePlay
    {
        #region Declare other classes to modify and use
        Game game = new Game();
        Round round = new Round();
        Player player1 = new Player();
        Player player2 = new Player();
        Round winner = new Round();
        private int p1 = 0; // win count for player 1
        private int p2 = 0; // win count for player 2
        private int ties = 0; // amount of tied rounds
        private int roundNumber = 0; // number of rounds
        private int p1Rand;
        private int p2Rand;
        private int win;
     
        
        #endregion
        // Main Method, Entry point, where the program begins
        static void Main()
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.GetNames();
            gamePlay.RunGame();
        }

        void GetNames()
        {
            Console.WriteLine("Enter Player 1 Name");
            player1.Name = Console.ReadLine();
            Console.WriteLine("Enter Player 2 Name");
            player2.Name = Console.ReadLine();
        }

        void Round()
        {

        }

        void Game()
        {
            game.p1 = player1;
            game.p2 = player2;
            if (p1 > 1)
            {    // print results and message stating player 1 wins
                Console.WriteLine($"{player1.Name} Wins {p2} - {p1} with {ties} ties.");
            }
            else
            { // print results and message staring player 2 wins
                Console.WriteLine($"{player2.Name} Wins {p2} - {p1} with {ties} ties.");
            }
            foreach (Round element in game.Rounds)
            {
                Console.WriteLine("Player 1 Chose" +" " + element.p1Choice + "Player 2 chose" +" "+ element.p2Choice + "Who won" + " " + element.Winner);
            }

        }
        #region RunGame
        void RunGame()
        {
           
            string[] rockPaperScis = { "rock", "paper","scissors" };
            Random rand = new Random();
            #region While Statement
            while (true)
            {
                roundNumber++;
                 p1Rand = rand.Next(3);
                p2Rand = rand.Next(3);
                round.p1Choice = rockPaperScis[p1Rand];
                round.p2Choice = rockPaperScis[p2Rand];
               win = p1Rand - p2Rand + 2;
                #region Switch Statment for figuring out who beats who
                switch (win)
                { //win is mostly unique varying with what each player picks
                    case 0: //p1 rock p2 scissor p1 wins
                        winner.Winner = player1;
                        winner.Winner.Name = player1.Name;
                        p1++;
                        game.Rounds.Add(round);
                        break;
                    case 1: // p1 lost since result is negative rock(0) - paper(1) or 1 - 2
                        winner.Winner = player2;
                        winner.Winner.Name = player2.Name;
                        p2++;
                        game.Rounds.Add(round);
                        break;
                    case 2: // tie
                        winner.Winner = null;
                        ties++;
                        game.Rounds.Add(round);
                        break;
                    case 3:// p1 wins as 1 - 0 or 2 - 1;
                        winner.Winner = player1;
                        winner.Winner.Name = player1.Name;
                        p1++;
                        game.Rounds.Add(round);
                        break;
                    case 4://p1 scissor p2 rock p2 wins
                        winner.Winner = player2;
                        winner.Winner.Name = player2.Name;
                        p2++;
                        game.Rounds.Add(round);
                        break;
                    default:
                        break;
                }
                #endregion
                if (p1 > 1 || p2 > 1)
                {
                    Game();
                    return;
                }
                #endregion
            }
        }
        #endregion




    }
}

  /*Console.WriteLine("Enter Player1 Name: "); //prompts user to input player 1 name
            String player1 = Console.ReadLine(); //takes input from user and stores it as player 1 name
            Console.WriteLine("Enter Player2 Name: "); //prompts user to input player 2 name
            String player2 = Console.ReadLine(); //takes input from user and stores it as player 2 name


            int p1 = 0; // win count for player 1
            int p2 = 0; // win count for player 2
            int ties = 0; // amount of tied rounds
            int round = 0; // number of rounds
            List<string> resultsList = new List<string>(); // results stored in a list
            string[] rps = { "Rock", "Paper", "Scissor" }; // Declare an string array to store Rock, Paper,and Scissors strings
            Random rand = new Random(); // instansiates the Random Class

            while (true)
            {
                round++; //increase the round by 1

                //randomly chooses rock paper or scissors for each player
                int p1rand = rand.Next(3);
                int p2rand = rand.Next(3);

                // to select a winner the switch statement is being utilized, see possible cases listed down below
                //0 rock, 1 paper, 2 scissors

                //p1 = 1 paper
                //p2 = 1
                //1-1+2 = 2

                //p1 = 2 scissors
                //p2 = 1 paper
                //2-1+2 = 3

                //p1 = 0 rock
                //p2 = 2 scissors
                //0-2+2 = 0

                int win = p1rand - p2rand + 2;
                // string of current round result to be stored in list
                string results = "Round " + round + " - " + player1 + " chose " + rps[p1rand];
                results += ", " + player2 + " chose " + rps[p2rand] + ". - ";

                switch (win)
                { //win is mostly unique varying with what each player picks
                    case 0: //p1 rock p2 scissor p1 wins
                        p1++;
                        break;
                    case 1: // p1 lost since result is negative rock(0) - paper(1) or 1 - 2
                        p2++;
                        break;
                    case 2: // tie
                        ties++;
                        break;
                    case 3:// p1 wins as 1 - 0 or 2 - 1;
                        p1++;
                        break;
                    case 4://p1 scissor p2 rock p2 wins
                        p2++;
                        break;
                    default:
                        break;
                }

                //adds the rest of the results to string stored in list
                if (win == 2) // tie
                {
                    results += player1 + " and " + player2 + " ties.";
                }
                else if (win == 0 || win == 3) // player1 wins
                {
                    results += player1 + " wins.";
                }
                else
                { //player2 wins
                    results += player2 + " wins.";
                }

                resultsList.Add(results); // store results in a list

                // conditions check to see if a player has won,checks if p1 or p2 has more than 2 wins.
                if (p1 > 1 || p2 > 1)
                {
                    // if either player has more than 2 wins print each result saved in the list
                    foreach (string element in resultsList)
                    { // prints all rounds played
                        Console.WriteLine(element);
                    }

                    if (p1 > 1)
                    {    // print results and message stating player 1 wins
                        Console.WriteLine($"{player1} Wins {p1} - {p2} with {ties} ties.");
                    }
                    else
                    { // print results and message staring player 2 wins
                        Console.WriteLine($"{player2} Wins {p2} - {p1} with {ties} ties.");
                    }

                    Player p10 = new Player();
                    p10.Name = "Mark";

                    Console.WriteLine($"My name is {p10.Name}.");



                    return; //ends program
                }
            }
        }*/