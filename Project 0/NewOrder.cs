using System;
using System.Collections.Generic;
using System.Text;
using Project_0.Models;

namespace Project_0
{
    public static class NewOrder
    {
        public static string custID {get;set;}
        private static Order curOrder = new Order();
        private static int orderID;
        public static int StoreID { get; set; }
        private static int manaPotionInStock;
        public static int ManaPotionsInStock { get => manaPotionInStock; set => manaPotionInStock = value; }
        private static int healthPotionInStock;
        public static int HealthPotionsInStock { get => healthPotionInStock; set => healthPotionInStock = value; }
        private static int staminaPotionInStock;
        public static int StaminaPotionsInStock { get => staminaPotionInStock; set => staminaPotionInStock = value; }




    }
}
