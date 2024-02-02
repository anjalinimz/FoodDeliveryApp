using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccountManager.Models
{
	public class CustomerAccDbContext : DbContext
    {
        public CustomerAccDbContext(DbContextOptions<CustomerAccDbContext> options) : base(options)
        {
        }

        // DbSet properties
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}

