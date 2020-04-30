using System;
using System.Collections.Generic;
using System.Text;
using Project_0.Models;


namespace Project_0
{
   public static class AddCustomer
    {
        private static Customer newCustomer = new Customer();
        public static Customer nCust { get; set; }
        private static string firstNameHolder;
        private static string lastNameHolder;
        private static string custID;
       public static void NewCustomer()
        {
            while (string.IsNullOrWhiteSpace(firstNameHolder) )
            {
                Console.WriteLine("Please enter your first name");
                firstNameHolder = Console.ReadLine().ToUpper();
            }
            while (string.IsNullOrWhiteSpace(lastNameHolder))
            {
                Console.WriteLine("Please Enter Your Last Name");
                lastNameHolder = Console.ReadLine().ToUpper();
            }
            newCustomer.FirstName = firstNameHolder;
            newCustomer.LastName = lastNameHolder;
            custID = firstNameHolder + lastNameHolder;
            newCustomer.CustomerID = custID;
            nCust = newCustomer;
            
        }

    }
}
