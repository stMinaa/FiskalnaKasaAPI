using System.ComponentModel.DataAnnotations;

namespace FiskalnaKasaAPI.Models
{
    public class PriceList
    {
        [Key]
        public int Id { get; set; }
        public int DeparmentId { get; set; }
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }

        public int PDVPercent { get; set; }
        public DateOnly PDVDateStart { get; set; }
        public DateOnly PDVDateEnd { get; set; }


        public Department? Deparment { get; set; }
        public Service? Service { get; set; }

    }
}
