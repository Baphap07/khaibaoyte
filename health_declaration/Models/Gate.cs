using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class Gate
    {
        public int GateId { get; set; }
        [Required]
        public string GateName { get; set; }
    }
}
