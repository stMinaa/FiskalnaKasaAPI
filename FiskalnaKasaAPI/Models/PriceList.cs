using System.Text.Json.Serialization;

namespace FiskalnaKasaAPI.Models
{
    public class PriceList
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public ICollection<PatientService>? PatientServices { get; set; }
    }
}
