using BankApp.Controllers;
using BankApp.Data.Configuration;
using BankApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BankApp.Data.Context
{
    public class BankContext:DbContext
    {
        public BankContext(DbContextOptions<BankContext> options):base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public static implicit operator BankContext(BankController v)
        {
            throw new NotImplementedException();
        }
    }
}
