using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengeWeek3
{
   internal static class PrintMultiplicationTable
    {
        //Reference https://www.w3schools.com/cs/cs_for_loop.asp
        private static string userInput;
        private static int numCheck;

        /// <summary>
        /// Below the multiplication table method validates the input making sure what 
        /// is put in is not null, and that it can be converted to an int then it takes the iput and
        /// runs it in a nested for loop that does the multiplication
        /// </summary>
        internal static void MultiplicationTables()
        {
            //Validates the input and ensures that it is an int. 
            #region ValidateInput and make sure it is an Int
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please Enter an Integer you would like see Muliplication Tables for");
                userInput = Console.ReadLine();
            }
            //try catch block that checks whether the input is valid by attempting to convert it to an int
            try
            {
                numCheck = Convert.ToInt32(userInput);
            }
            // catch format exception when the user types anything other than an int 
            catch (FormatException e)
            {
                Console.WriteLine(userInput + " is not a valid integer", e);
                userInput = null;
                MultiplicationTables();
            }
            #endregion
            /// for loop that runs for every number lower than or equal to the user input number
            /// it then takes the local variables computes a multiplication for them and prints out the
            /// results with the console writeline
            for (int i = 1; i <= numCheck; i++)
            {
                for (int j = 0; j <= numCheck;j++ )
                {
                    Console.WriteLine("{0}x{1} = {2}", i, j, i * j);
                }
            }
            //run app again to go back to main menu
            RunApplication.RunApp();
        }
    }
}
