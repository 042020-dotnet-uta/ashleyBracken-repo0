using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project_0;
using System.Linq;

namespace DataAccess
{
    internal class AccessCustomer
    {
    
      internal  void AddCusToDataBase()
        {
            using (var db = new DataBaseContext())
            {
                
                db.Add(AddCustomer.nCust);
                db.SaveChanges();
            }
        }

    }
}
