using System;
using System.Collections.Generic;
using System.Text;
using Project_0;
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
        private static int totalHealth;
        private static int totalMana;
        private static int totalStamina;
        public static int HealthInStock { get; set; }
        public static int ManaInStock { get; set; }
        public static int StaminaInStock { get; set; }

        public static void NewOrderSetup()
        {
            custInput = null;
            while (string.IsNullOrWhiteSpace(custInput))
            {
                Console.WriteLine("Please enter which potion you are interested int \n type HEALTH for a health potion" +
                    "\n Type MANA for a Mana Potion \n Type Stamina for Stamina Potions");
                custInput = Console.ReadLine().ToUpper();
            }
            switch (custInput)
            {
                case "HEALTH":
                    inStock = HealthInStock;
                    ChoosePotionQuantity();
                    CheckInventory();
                    HealthInStock -= howManytoBuy;
                    totalHealth += howManytoBuy;
                    PlaceNewOrderCheck();
                
                    
                    break;
                case "MANA":
                    inStock = ManaInStock;
                    ChoosePotionQuantity();
                    CheckInventory();
                    ManaInStock -= howManytoBuy;
                    totalMana += howManytoBuy;
                    PlaceNewOrderCheck();
          
                    
                    break;
                case "STAMINA":
                    inStock = StaminaInStock;
                    ChoosePotionQuantity();
                    CheckInventory();
                    StaminaInStock -= howManytoBuy;
                    totalStamina += howManytoBuy;
                    PlaceNewOrderCheck();
              
                    break;
                default:
                    Console.WriteLine("You have not chosen one of the options");
                    NewOrderSetup();
                    break;
            }

            static void PlaceNewOrderCheck()
            {
                Console.WriteLine("Would you like to add another item? \n Type YES if you would like to add another item\n Press enter to go to checkout");
                custInput = Console.ReadLine().ToUpper();
                if (custInput == "YES")
                {
                    NewOrderSetup();
                }
                else PlaceOrder();
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

            static void PlaceOrder()
            {
                curOrder.HealthPotionsBought = totalHealth;
                curOrder.ManaPotionsBought = totalMana;
                curOrder.StaminaPotionsBought = totalStamina;
                curOrder.Date = date;
                CurOrder = curOrder;
            }
        }
    }
}
