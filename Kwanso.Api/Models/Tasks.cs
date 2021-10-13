using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kwanso.Api.Models
{
    public class Tasks
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public bool? IsDelete { get; set; } = false;
        public string UsersId { get; set; }
        //public ApplicationUser Users { get; set; }
    }
}
