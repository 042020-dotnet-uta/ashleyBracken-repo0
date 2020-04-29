using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;


namespace Project_0
{
    class RunApplication 
    {
        private string add;
        private string existing;
        private string custInput;

        internal void RunApp()
        {
            GetCustStatus();
            if (custInput == add)
            {
                Console.WriteLine("You have entered ADD");
                AddCustomer newCust = new AddCustomer();
                newCust.NewCustomer();
                
            }
            else if (custInput == existing)
            {
                Console.WriteLine("You Have entered EXISTING");
            }
            else
            {
                Console.WriteLine("You have not entered one of the options please enter againg");
                RunApp();
            }
        }
            
        void GetCustStatus()
        {
            add = "ADD";
            existing = "EXISTING";
            Console.WriteLine("Type " + add + " if you are a new customer");
            Console.WriteLine("Type " + existing + " if you are an existing customer");
            custInput = Console.ReadLine().ToUpper();
        }
    }
}
