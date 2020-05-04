using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project_0;
using Project_0.Models;
using System.Linq;


namespace DataAccess
{
    class InventoryAccess
    {
        internal void GetStoreInventory()
        {
            Potions potion;
            Customer curCust;
            int curStore;
            using (var db = new DataBaseContext())
            {
                curCust = db.Customers.Where(cust => cust.CustomerID == GetCustLookupInfo.CustIDHolder).FirstOrDefault();
                curStore = curCust.StoreID;
                NewOrder.HealthPotionsInStock = db.Inventory.Where(inv =>inv.StoreID == curStore).FirstOrDefault();

            }
        }
    }
}
