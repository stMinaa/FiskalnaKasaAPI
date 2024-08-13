using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FiskalnaKasaAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CompanyId { get; set; }
        public string? Email { get; set; }
        public Company? Company { get; set; }
        
        [JsonIgnore]
        public ICollection<Invoice>? Invoices { get; set; }
    }
}
