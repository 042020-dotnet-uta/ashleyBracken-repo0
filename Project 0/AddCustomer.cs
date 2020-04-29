using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;


namespace Project_0
{
    internal class AddCustomer 
    {
        Customer newCustomer = new Customer();
        AccessCustomer newCust = new AccessCustomer();
        private string firstNameHolder;
        private string lastNameHolder;
        private string custID;
       internal void NewCustomer()
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
            newCust.nCust = newCustomer;
            
        }

    }
}
