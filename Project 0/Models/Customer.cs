using System;
using System.Collections.Generic;
using System.Text;

namespace Project_0.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public Customer() { }
        private string firstName;
        public string FirstName { get =>firstName;set=>firstName = value; }
        private string lastName;
        public string LastName { get=>lastName;set=>lastName = value; }

    }
}
