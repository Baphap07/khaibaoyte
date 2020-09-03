using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class Province
    {
        
        public int ProvinceId { get; set; }
        [Required]
        public string ProvinceName { get; set; }
        [Required]
        public string Code { get; set; }

    }
}
