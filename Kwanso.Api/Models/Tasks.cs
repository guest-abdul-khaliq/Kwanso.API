using System;
using System.ComponentModel.DataAnnotations;

namespace Kwanso.Api.Models
{
    public class Tasks
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public bool? IsDelete { get; set; } = false;
        public string UsersId { get; set; }
    }
}
