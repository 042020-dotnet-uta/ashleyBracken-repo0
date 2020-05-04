using System;
using System.Collections.Generic;
using System.Text;



namespace Project_0
{
    public static class RunApplication
    {
        private static string add;
        private static string existing;
        private static string custInput;
        private static bool storeChosen = false;
        private static string newOrder;
        private static string lookUpOrders;
        public static bool StoreChosen { get => storeChosen; set => storeChosen = value; }
        private static bool cusExists;
        public static bool CusExists { get => cusExists; set => cusExists = value; }


        public static void RunApp()
        {
            cusExists = false;
           
            if (storeChosen == true)
            {
                Console.Clear();
                NewOrderOrLookUP();
            }
            else GetCustStatus();
            switch (custInput)
            {
                case "ADD":
                    Console.WriteLine("You have entered ADD");
                    AddCustomer.NewCustomer();
                    cusExists = false;
                    Console.Clear();
                    break;
                case "EXISTING":
                    Console.WriteLine("You Have entered EXISTING");
                    cusExists = true;
                    Console.Clear();
                    break;
                case "NEW":
                    break;
                case "LOOKUP":
                    break;
                default:
                    Console.WriteLine("You have not entered one of the options please enter again");
                    RunApp();
                    break;
            }
        }
            
        static void  GetCustStatus()
        {
            add = "ADD";
            existing = "EXISTING";
            Console.WriteLine("Type " + add + " if you are a new customer");
            Console.WriteLine("Type " + existing + " if you are an existing customer");
            custInput = Console.ReadLine().ToUpper();
        }

        static void NewOrderOrLookUP()
        {
            newOrder = "NEW";
            lookUpOrders = "LOOKUP";
            Console.WriteLine("Type " + newOrder + " If you are wanting to place a new order with this store");
            Console.WriteLine("Type " + lookUpOrders + " If you are wanting to look up previous orders");
            custInput = Console.ReadLine().ToUpper();
        }

    }
}
