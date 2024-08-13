using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FiskalnaKasaAPI.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceNumber { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public ICollection<PriceList>? DepartmentList { get; set; }
    }
}
