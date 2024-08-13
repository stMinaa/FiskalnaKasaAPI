using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FiskalnaKasaAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public bool CustomerType { get; set; }
        public string? PIB { get; set; } // PIB za pravna lica
        public string? JMBG { get; set; } // JMBG za fizička lica
        public string? Name { get; set; }   //ime firme/ime coveka

        [JsonIgnore]
        public ICollection<InvoiceItem>? InvoiceItems { get; set; }
    }
}
