using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project_0.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int PotionID { get; set;}
        public int PotionQuantity { get; set;}

    }
}
