using System.ComponentModel.DataAnnotations;

namespace FiskalnaKasaAPI.Models
{
    public class InvoiceItem
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? PriceListId { get; set; }
        public DateTime ServiceDate { get; set; }
        public Customer? Customer { get; set; }
        public PriceList? PriceList { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice   //cena za kolicinu 
        {
            get
            {
                return (PriceList?.Price ?? 0) * Quantity;
            }
        }

        public decimal PDVShare 
        {
            get
            {
                return TotalPrice * (PriceList?.PDVPercent ?? 0 / 100);
            } 
        }

        public int? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

    }
}
