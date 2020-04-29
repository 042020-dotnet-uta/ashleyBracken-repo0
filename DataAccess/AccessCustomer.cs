using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AccessCustomer
    {
        public Customer nCust {get;set;}
      public  void AddCusToDataBase()
        {
            using (var db = new DataBaseContext())
            {

                db.Add(nCust);
                db.SaveChanges();
            }
        }

    }
}
