using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeWeek3
{
   internal static class CheckIfEven
    {
        #region Fields
        // declare private fields to use in this class. 
        private static string userInput;
        private static int numCheck;
        #endregion
        /// <summary>
        /// Is even checks to see if the number input is divisable by 2 and 
        /// therefore even after trying to covert the userInput to int, if 
        /// it can't convert the user input to int it will catch a format exception
        /// </summary>
        internal static void IsEven()
        {
            ConsoleKeyInfo esc;
            Console.WriteLine("Press the Escape (Esc) at any time to quit: \n");
            #region Validate Input
            // while check to make sure the user didn't put nothing
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please Enter an Integer you would like to check");
               userInput =  Console.ReadLine();
            }
            //try catch block that checks whether the input is valid by attempting to convert it to an int
            try
            {
                numCheck = Convert.ToInt32(userInput);
            }
            // catch format exception when the user types anything other than an int 
            catch (FormatException e)
            {
                Console.WriteLine( userInput+" is not a valid integer", e);
                userInput = null;
                IsEven();
            }
            #endregion
            #region Check Results
            // check to see if the number is divisable by 2 
            if (numCheck % 2 == 0)
            {
                Console.WriteLine(userInput + " is Even");
                userInput = null;
            }
            // if it is not divisable by 2 notify the user
            else
            {
                Console.WriteLine(userInput + " is not Even");
                userInput = null;
            }
            #endregion
            // run applicaiton from the main menu again since this task has been completed.
            RunApplication.RunApp();

        }
    }
}
