using Microsoft.EntityFrameworkCore;
using FiskalnaKasaAPI.Models;

namespace FiskalnaKasaAPI.Data
{
    public class KasaContext : DbContext
    {

        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }



        public KasaContext(DbContextOptions<KasaContext> options) : base(options) { }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Company - User (1:N)
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Users)
                .WithOne(u => u.Company)
                .HasForeignKey(u => u.CompanyId);

            // Customer - InvoiceItem (1:N)
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.InvoiceItems)
                .WithOne(ii => ii.Customer)
                .HasForeignKey(ii => ii.CustomerId);

            // Department - PriceList (1:N)
            modelBuilder.Entity<Department>()
                .HasMany(d => d.ServiceList)
                .WithOne(pl => pl.Deparment)
                .HasForeignKey(pl => pl.DeparmentId);

            // Service - PriceList (1:N)
            modelBuilder.Entity<Service>()
                .HasMany(s => s.DepartmentList)
                .WithOne(pl => pl.Service)
                .HasForeignKey(pl => pl.ServiceId);

            // Invoice - InvoiceItem (1:N)
            modelBuilder.Entity<Invoice>()
                .HasMany(i => i.PatientServices)
                .WithOne(ii => ii.Invoice)
                .HasForeignKey(ii => ii.InvoiceId);

            // InvoiceItem - PriceList (M:1)
            modelBuilder.Entity<InvoiceItem>()
                .HasOne(ii => ii.PriceList)
                .WithMany()
                .HasForeignKey(ii => ii.PriceListId);

            // Invoice - User (N:1)
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.User)
                .WithMany(u => u.Invoices)
                .HasForeignKey(i => i.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}   
