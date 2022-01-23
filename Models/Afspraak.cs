
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WDPR.Models;

public class Afspraak
{
        [Key]
        public int Nummer { get; set; }

        public Orthopedagoog orthopedagoog { get; set; }

        public List<Gebruiker> clienten { get; set;}

}

