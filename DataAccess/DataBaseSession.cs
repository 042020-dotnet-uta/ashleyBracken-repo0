using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace DataAccess 
{
   public class DataBaseContext : DbContext
    {
       
      public DbSet<Customer> Customers { get;set;}
      public DbSet<Store> Store { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=blogging.db");
            }
        }

    }

}
