using System.ComponentModel.DataAnnotations;

namespace FiskalnaKasaAPI.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<string>? Adresses { get; set; }
        public int PIB { get; set; }
        public List<User>? Users { get; set; }



    }
}
