namespace FiskalnaKasaAPI.Models
{
    public class PatientService
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime ServiceDate { get; set; } 
        public int? PriceListId { get; set; }

        public int? InvoiceId { get; set; }

        public Patient? Patient { get; set; }
        public PriceList? PriceList { get; set; }

        public Invoice? Invoice { get; set; }
        
    }
}
