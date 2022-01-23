
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WDPR.Models;

public class Orthopedagoog : IdentityUser
{
        [Key]
        public int ID { get; set; }

        public List<Gebruiker> clienten { get; set;}

}

