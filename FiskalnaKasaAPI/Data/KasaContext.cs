using Microsoft.EntityFrameworkCore;
using FiskalnaKasaAPI.Models;

namespace FiskalnaKasaAPI.Data
{
    public class KasaContext : DbContext
    {
        public KasaContext(DbContextOptions<KasaContext> options) : base(options) { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }
}
