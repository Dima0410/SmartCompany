using Microsoft.EntityFrameworkCore;
using SmartCompany.Models;
using System.Diagnostics;

namespace SmartCompany.Data
{
    public class DBContextTables : DbContext
    {
        public DBContextTables(DbContextOptions<DBContextTables> options) : base(options)
        {
            Console.WriteLine($"{ContextId} context created.");
        }

        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Outlay> Outlays { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Profit> Profits { get; set; }
    }
}
