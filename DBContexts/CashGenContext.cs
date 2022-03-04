using CashGen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CashGen.DBContexts
{
    public class CashGenContext: DbContext
    {
        public CashGenContext(DbContextOptions<CashGenContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                Store store1 = new Store();
                store1.Id = Guid.Parse("ff71fc86-5bb1-4cb6-a56f-efe88d113733");
                store1.Email = "craig@day32.co.uk";
                store1.Title = "Test Store";
                Store[] storeArray1 = new Store[] { store1 };
                modelBuilder.Entity<Store>().HasData(storeArray1);
                Product product1 = new Product();
                product1.Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97");
                product1.StoreId = Guid.Parse("ff71fc86-5bb1-4cb6-a56f-efe88d113733");
                product1.Email = "craig@day32.co.uk";
                product1.Title = "Sony PS4";
                product1.Barcode = "ABCD1234";
                product1.Price = Convert.ToDecimal((double)179.99);
                Product[] productArray1 = new Product[] { product1 };
                modelBuilder.Entity<Product>().HasData(productArray1);
                base.OnModelCreating(modelBuilder);
            }
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<Filter> Filters { get; set; }

        public DbSet<FilterOption> FilterOptions { get; set; }

        public DbSet<FilterCollection> FilterCollections { get; set; }

        public DbSet<ProductFilter> ProductFilters { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ShopifyCollect> ShopifyCollects { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<StoreUser> StoreUsers { get; set; }

        public DbSet<EventLog> EventLogs { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public class CashGenContextFactory : IDesignTimeDbContextFactory<CashGenContext>
        {
            public CashGenContext CreateDbContext(string[] args)
            {
                DbContextOptionsBuilder<CashGenContext> builder1 = new DbContextOptionsBuilder<CashGenContext>();
                SqlServerDbContextOptionsExtensions.UseSqlServer<CashGenContext>(builder1, "Server=tcp:cashgen.database.windows.net,1433;Initial Catalog=cashgen;Persist Security Info=False;User ID=craigmanx;Password=$Plokij32;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", null);
                return new CashGenContext(builder1.Options);
            }
        }
    }
}
