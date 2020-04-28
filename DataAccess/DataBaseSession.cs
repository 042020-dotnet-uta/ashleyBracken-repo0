using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Project_0.Models;


namespace DataAccess 
{
   public class DataBaseSession : DbContext
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
