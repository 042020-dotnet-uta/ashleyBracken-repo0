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
        private int manaStock;
        private int healthStock;
        private int staminaStock;
        internal void GetStoreInventory()
        {
            Customer curCust;
            int curStore;
            using (var db = new DataBaseContext())
            {
                curCust = db.Customers.Where(cust => cust.CustomerID == GetCustLookupInfo.CustIDHolder).FirstOrDefault();
                curStore = curCust.StoreID;
                healthStock = db.Inventory.Where(inv => inv.StoreID == curStore)
                    .Where(pID => pID.PotionID == 1).Select(inv => inv.PotionQuantity).FirstOrDefault();
                manaStock = db.Inventory.Where(inv => inv.StoreID == curStore)
                    .Where(pID => pID.PotionID == 2).Select(inv => inv.PotionQuantity).FirstOrDefault();
                staminaStock = db.Inventory.Where(inv => inv.StoreID == curStore)
                    .Where(pID => pID.PotionID == 3).Select(inv => inv.PotionQuantity).FirstOrDefault();
                Console.WriteLine(staminaStock);
            }
            NewOrder.HealthInStock = healthStock;
            NewOrder.ManaInStock = manaStock;
            NewOrder.StaminaInStock = staminaStock;
 
        }
    }
}
