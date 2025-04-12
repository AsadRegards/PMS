using Microsoft.EntityFrameworkCore;
using PMS.PMS.Model;
using System;

namespace PMS.PMS.Data
{
    internal class PmsDbContext : DbContext
    {
        // Static instance of the DbContext
        private static PmsDbContext _instance;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Public DbSet properties
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItems> SaleItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ChangeLog> ChangeLog { get; set; } 

        // Private constructor to prevent external instantiation
        private PmsDbContext(DbContextOptions<PmsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //Public Constructor created in order for entity framework to successfully performs migrations. [[DO NOT REMOVE THIS CONSTRUCTOR]]
        public PmsDbContext() : base(new DbContextOptions<PmsDbContext>())
        {

        }

        // Public static method to get the singleton instance
        public static PmsDbContext Instance
        {
            get
            {
                // Double-check locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            // Create an options object (you can replace this with your actual options setup)
                            var options = new DbContextOptionsBuilder<PmsDbContext>()
                                          .UseSqlite("Data Source=pharmacy.db")
                                          .Options;
                            _instance = new PmsDbContext(options);
                        }
                    }
                }
                return _instance;
            }
        }

        // Override OnConfiguring method (not needed in this case due to singleton pattern)
        // If you still want the flexibility to configure options dynamically, keep this
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=pharmacy.db");
        }
    }
}
