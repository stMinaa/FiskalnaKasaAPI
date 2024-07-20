namespace FiskalnaKasaAPI.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Invoice Invoice { get; set; }
        public Service Service { get; set; }
    }
}
