﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Project_0.Models;
using System.Linq;

namespace DataAccess 
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders {get;set;}
        public DbSet<Store> Stores { get; set; }
        public DbSet<Potions> Potions { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<StoreInventory> StoreInventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=TheSleepingSelkie.db");
            }
        }

    }

}