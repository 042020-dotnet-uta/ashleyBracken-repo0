using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengeWeek3
{
    internal static class RunApplication
    {
        private static string userInput;

        public static void RunApp()
        {
            //Console.Clear();
            Console.WriteLine("If you are wanting to check if your number is even please type EVEN, " +
                "\n If you are wanting print multiplication tables please type MULTIPLY\n If you are wanting to Shuffle please type SHUFFLE \n Type EXIT to close this application");
            userInput = Console.ReadLine().ToUpper();
           
            switch (userInput)
            {
                case "EVEN":
                    Console.Clear();
                    CheckIfEven.IsEven();
                    break;
                case "MULTIPLY":
                    Console.Clear();
                    PrintMultiplicationTable.MultiplicationTables();
                    break;
                case "SHUFFLE":
                    Console.Clear();
                    ShuffleCollections shuffle = new ShuffleCollections();
                    shuffle.ShuffleInfo();
                    break;
                case "EXIT":
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You have not entered one of the options, Please try again");
                    RunApp();
                    break;
            }
                


        }


    }
}
