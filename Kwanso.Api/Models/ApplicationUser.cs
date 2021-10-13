using Microsoft.AspNetCore.Identity;
using System;

namespace Kwanso.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime? CreatedAT { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
