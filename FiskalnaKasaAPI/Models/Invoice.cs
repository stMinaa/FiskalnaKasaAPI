namespace FiskalnaKasaAPI.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string FiscalNumber { get; set; }
        public User User { get; set; }
        public List<InvoiceItem> Items { get; set; }
    }
}
