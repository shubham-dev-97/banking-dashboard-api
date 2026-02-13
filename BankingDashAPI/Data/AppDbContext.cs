using BankingDashAPI.Models;
using BankingDashAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankingDashAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }


        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Deposit
            modelBuilder.Entity<Deposit>()
                .Property(d => d.Balance)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Deposit>()
                .Property(d => d.InterestRate)
                .HasPrecision(5, 4);

            // Loan
            modelBuilder.Entity<Loan>()
                .Property(l => l.Amount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Loan>()
                .Property(l => l.Outstanding)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Loan>()
                .Property(l => l.InterestRate)
                .HasPrecision(6, 2);

            // Transaction
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasPrecision(18, 2);



            modelBuilder.Entity<AdminUser>().HasData(
        new AdminUser
        {
            Id = 1,
            UserName = "NeurofinTech",
            PasswordHash = "admin123",
            FullName = "Onkar Bhosale"
        }
    );
        }

    }




}
