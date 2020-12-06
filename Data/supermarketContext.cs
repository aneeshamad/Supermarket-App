using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    class supermarketContext: DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Single_User> Single_Users { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<Transaction_item> Transaction_items { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8BA4LM0;Database=SupermarketDB;Trusted_Connection=True;");

        }

        

    }
}
