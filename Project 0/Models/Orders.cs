using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_0.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public string CustomerID { get; set; }
        public Store Store { get; set; }
        public int StoreID { get; set; }
        public int ManaPotionsBought { get; set; }
        public int HealthPotionsBought { get; set; }
        public int StaminaPotionsBought { get; set; }

        private DateTime date;
        public DateTime Date { get=>date; set=>date=value; }
        public Order() { }
    }
}
