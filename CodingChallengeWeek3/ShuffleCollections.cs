using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengeWeek3
{
    internal class ShuffleCollections
    {
        // declare variables to use, user input for user input and an array
        // for each list put in, a count for how many items in the array 
        // and a new list for the combined arrays
        private string userInput;
        private int listOneItems = 0;
        private int listTwoItems = 0;
        private string[] listTwo = new string[5];
        private string[] listOne = new string[5];
        private List <string> combinedList = new List<string>();
        /// <summary>
        /// Validate that the user input information is not empty
        /// accept input from the user and assign the correlating arrays
        /// combine the arrays at the indexes into a list that alternates between each list
        /// </summary>
        internal void ShuffleInfo()
        {

            // Do- while runs while the each lists is less than the target number
            // does this for each list until each list is full of the customer provided input
            #region Validate that input is not null and add input to first list
            do
            {
                userInput = null;
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Enter an item for the first list \n List item number : " + listOneItems);
                    userInput = Console.ReadLine();
                    listOne[listOneItems] = userInput;
                    listOneItems++;
                    Console.Clear();
                }
            } while (listOneItems <= 4);
            #endregion
            #region Validate that input is not null and add input to Second list
            do
            {
                userInput = null;
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Enter an item for the Second list\n List item number :" + listTwoItems);
                    userInput = Console.ReadLine();
                    listTwo[listTwoItems] = userInput;
                    listTwoItems++;
                    Console.Clear();
                }
            } while (listTwoItems <= 4 );
            #endregion
            // run a for loop that adds the list one item at the index to the combined
            //list and the list 2 item at that same index, this will alternate the results
            for (int i = 0; i<listOne.Length;i++)
            {
                combinedList.Add(listOne[i]);
                combinedList.Add(listTwo[i]);
            }
            // For each loop to read out each item saved in the combined list
            foreach (string listItem in combinedList)
            {
                Console.WriteLine(listItem);
            }
            //run application again to start it all over
            RunApplication.RunApp();
            
        }
    }
}

