
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WDPR.Models
{
    public class Gebruiker : IdentityUser
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Leeftijd { get; set; }

        public Orthopedagoog orthopedagoog { get; set; }

        public Afspraak afspraak { get; set; }

        public Voogd voogd { get; set; }
    }
}
