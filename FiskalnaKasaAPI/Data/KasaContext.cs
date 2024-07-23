using Microsoft.EntityFrameworkCore;
using FiskalnaKasaAPI.Models;

namespace FiskalnaKasaAPI.Data
{
    public class KasaContext : DbContext
    {

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientService> PatientServices { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<User> Users { get; set; }


        public KasaContext(DbContextOptions<KasaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.User)
                .WithMany(u => u.Invoices)
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<PatientService>()
                .HasOne(ps => ps.Patient)
                .WithMany(p => p.PatientServices)
                .HasForeignKey(ps => ps.PatientId);

            modelBuilder.Entity<PatientService>()
                .HasOne(ps => ps.PriceList)
                .WithMany(pl => pl.PatientServices)
                .HasForeignKey(ps => ps.PriceListId);

            modelBuilder.Entity<PatientService>()
                .HasOne(ps => ps.Invoice)
                .WithMany(i => i.PatientServices)
                .HasForeignKey(ps => ps.InvoiceId);
        }
    }
}
