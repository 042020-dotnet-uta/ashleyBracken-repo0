using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project_0;
using Project_0.Models;
using System.Linq;

namespace DataAccess
{
    class AccessOrders
    {

        internal void AddNewOrder()
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    db.Add(NewOrder.CurOrder);
                    db.SaveChanges();
                    Console.WriteLine("Your Order has been placed, please pick up at your preferred store");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong with placing the order",e);
                }  
            }
        }
    }
}
