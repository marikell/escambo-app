using Microsoft.AspNetCore.Identity;
using System;

namespace Escambo.Infra.CrossCutting.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
