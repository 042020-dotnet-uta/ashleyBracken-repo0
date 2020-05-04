using System;
using System.Collections.Generic;
using System.Text;

namespace Project_0
{
    public static class NewOrder
    {
        public static string custID {get;set;}
        private static int orderID;
        public static int OrderID { get=>orderID; set=>orderID= value; }
        public static int StoreID { get; set; }

    }
}
