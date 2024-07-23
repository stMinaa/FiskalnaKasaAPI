﻿using System.Text.Json.Serialization;

namespace FiskalnaKasaAPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        [JsonIgnore]
        public ICollection<PatientService>? PatientServices { get; set; }
    }
}
