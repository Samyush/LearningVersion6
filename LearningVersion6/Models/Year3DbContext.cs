using System.ComponentModel.DataAnnotations;
using LearningVersion6.Models.Finance;
using Microsoft.EntityFrameworkCore;

namespace LearningVersion6.Models
{
    public class Year3DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<TransactionTypes> TransactionTypes { get; set; }
        
        public Year3DbContext(DbContextOptions<Year3DbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}