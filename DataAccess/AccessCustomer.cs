using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project_0;
using Project_0.Models;
using System.Linq;


namespace DataAccess
{
    internal class AccessCustomer
    {
        private static bool cusFound = false;
        public static bool CusFound { get => cusFound; set => cusFound = value; }
        private Customer existingCust ;
        public Customer ExistingCustomer { get => existingCust; set => existingCust = value; }
        private int preferredStore;
        public int PreferredStore { get=>preferredStore; set=>preferredStore = value; }
        private Store store;
        internal void AddCusToDataBase()
        {
            using (var db = new DataBaseContext())
            {
              
                    db.Add(AddCustomer.nCust);
                    db.SaveChanges();
                NewOrder.StoreID = AddCustomer.nCust.StoreID;
                NewOrder.custID = AddCustomer.nCust.CustomerID;
                RunApplication.StoreChosen = true;
            }
        }
        /// <summary>
        /// The Folowing method accesses customer data from the Database
        /// </summary>
        internal void LookUpCustFromDB()
        {
            {
                /// setting existingCust(which is basically cur user to the customer that correlates with the customer ID entered by the user)
                using (var db = new DataBaseContext())
                {
                    existingCust = db.Customers.Where(cust => cust.CustomerID == GetCustLookupInfo.CustIDHolder).FirstOrDefault();
                    store = db.Stores.Where(stores => stores.StoreID == existingCust.StoreID).FirstOrDefault();
                    try
                    {
                        /// trys to write a greeting for the returning customer, if it is properly assigned
                        Console.WriteLine("Welcome Back " + existingCust.FirstName);
                        if (existingCust.StoreID != 0)
                        {
                            Console.WriteLine("Your current preferred store is " + store.StoreName + "Store Number " + existingCust.StoreID +
                                "\n If you would like to change your prefered store type yes otherwise press enter");
                            if (Console.ReadLine().ToUpper() == "YES")
                            {
                                existingCust.StoreID = 0;
                            }
                            else
                            {
                                NewOrder.StoreID = existingCust.StoreID;
                                NewOrder.custID = existingCust.CustomerID;
                                RunApplication.StoreChosen = true;
                                RunApplication.RunApp();
                            }
                        }
                        if (existingCust.StoreID <= 0 || existingCust.StoreID >= 4)
                        {
                            GetCustLookupInfo.SetDefaultStore();
                            try
                            {
                                existingCust.StoreID = Convert.ToInt32(GetCustLookupInfo.StoreNumber);
                                db.SaveChanges();
                                NewOrder.StoreID = existingCust.StoreID;
                                NewOrder.custID = existingCust.CustomerID;
                                RunApplication.StoreChosen = true;
                                RunApplication.RunApp();
                            }
                            catch (FormatException exception)
                            {
                                Console.WriteLine("Please Format Store Identification as an Int", exception);
                            }
                        }
                    }
                    catch (NullReferenceException exception)
                    {
                        Console.WriteLine("That customer was Not found", exception);
                        Console.Clear();
                    }
                }
            }
        }          
    }
}
