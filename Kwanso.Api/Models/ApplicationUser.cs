using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kwanso.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime? CreatedAT { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
