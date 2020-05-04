using System;
using System.Collections.Generic;
using System.Text;

namespace Project_0
{
    public static class GetCustLookupInfo
    {
        
        private static string storeNumber;
        public static string StoreNumber { get=>storeNumber; set=>storeNumber = value; }
        private static string custIDHolder;
        public static string CustIDHolder { get => custIDHolder; set => custIDHolder = value; }

        public static void GetCustID()
        {
            while (string.IsNullOrWhiteSpace(custIDHolder))
            {
                Console.WriteLine("Please Enter your Phone Number");
                custIDHolder = Console.ReadLine().ToUpper();
            }
        }

        public static void SetDefaultStore()
        {
            while (string.IsNullOrWhiteSpace(storeNumber) )
            {
                Console.WriteLine("You do not currently have a preferred store, " +
                    "Please choose a store from the following options \n  type 1 for the primary location \n " +
                    "type 2 for the Secondary location \n type  3 for the third location ");
                storeNumber = Console.ReadLine();
              
            }
        }
    } 
}
