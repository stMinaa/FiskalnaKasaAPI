using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FiskalnaKasaAPI.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string? DepartmentName { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public ICollection<PriceList>? ServiceList { get; set; }
    }
}
