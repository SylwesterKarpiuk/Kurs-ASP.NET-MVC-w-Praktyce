using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public StoreContext() : base("StoreContext")
        {

        }
        static StoreContext()
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }
    }
}