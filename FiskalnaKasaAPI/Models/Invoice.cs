using System.ComponentModel.DataAnnotations;

namespace FiskalnaKasaAPI.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string? ESIR { get; set; }
        public int? PFR { get; set; }
        public int? PFRTime { get; set; }
        public string? BrojacRacuna { get; set; }
        public List<PaymentType>? PaymentType { get; set; } // Tip plačanja
        public int? UserId { get; set; }
 
        public User? User { get; set; }
        public ICollection<InvoiceItem>? PatientServices { get; set; }  //tako je ostalo da se zove InoviceItems

        
    }

    public enum PaymentType
    {
        Gotovina,
        KreditnaKartica,
        Cekovi,
        Virman
    }
}
