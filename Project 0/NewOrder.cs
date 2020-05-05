using System;
using System.Collections.Generic;
using System.Text;
using Project_0.Models;

namespace Project_0
{
    public static class NewOrder
    {
        public static string custID { get; set; }
        private static string custInput;
        private static Order curOrder = new Order();
        public static Order CurOrder { get; set; }
        private static int orderID;
        private static DateTime date;
        public static int StoreID { get; set; }
        private static int howManytoBuy;
        private static int inStock;
        public static int HealthInStock { get; set; }

        public static void PlaceNewOrder()
        {
            while (string.IsNullOrWhiteSpace(custInput))
            {
                Console.WriteLine("Please enter which potion you are interested int \n type HEALTH for a health potion" +
                    "\n Type MANA for a Mana Potion \n Type Stamina for Stamina Potions");
                custInput = Console.ReadLine().ToUpper();
            }
            switch (custInput)
            {
                case "HEALTH":
                    ChoosePotionQuantity();
                    CheckInventory();
                    break;
                case "MANA":
                    break;
                case "STAMINA":
                    break;
                default:
                    Console.WriteLine("You have not chosen one of the options");
                    PlaceNewOrder();
                    break;
            }

            static void ChoosePotionQuantity()
            {
                Console.WriteLine("How many would you like to buy");
                howManytoBuy = Convert.ToInt32(Console.ReadLine());
            }
            static void CheckInventory()
            {
                if (howManytoBuy > inStock)
                {
                    Console.WriteLine("There are not that many in stock");
                    ChoosePotionQuantity();
                }
            }

            //curOrder.OrderID = Convert.ToInt32(custID + date);
        }
    }
}
