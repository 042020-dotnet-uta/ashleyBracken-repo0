using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project_0.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public Customer() { }
        private string firstName;
        public string FirstName { get =>firstName;set=>firstName = value; }
        private string lastName;
        public string LastName { get=>lastName;set=>lastName = value; }
        public int StoreID { get; set; }

    }
}
