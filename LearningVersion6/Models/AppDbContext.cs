using System.ComponentModel.DataAnnotations;
using LearningVersion6.Models.Finance;
using LearningVersion6.Models.Finance.Income;
using LearningVersion6.Models.Finance.Payments;
using Microsoft.EntityFrameworkCore;

namespace LearningVersion6.Models
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Payments> Payments { get; set; }
        //public DbSet<TransactionType> TransactionTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}