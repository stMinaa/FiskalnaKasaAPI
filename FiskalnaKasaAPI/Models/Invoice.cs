namespace FiskalnaKasaAPI.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string? FiscalNumber { get; set; }
        public string? Status { get; set; }  // paid/nije paid
        public int? UserId { get; set; }
        public DateTime? PaymentTimestamp { get; set; }
 
        public User? User { get; set; }
        public ICollection<PatientService>? PatientServices { get; set; }
    }
}
