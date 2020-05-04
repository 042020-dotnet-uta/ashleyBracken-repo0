using System;
using System.Collections.Generic;
using System.Text;

namespace Project_0.Models
{
    public class StoreInventory
    {
        public int StoreInventoryID { get; set; }
        public Store Store {get;set;}
        public int StoreID { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryID { get; set; }
    }
}
