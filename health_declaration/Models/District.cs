using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class District
    {
        public int DistrictId { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public string Prefix { get; set; }
        
        public int ProvinceId { get; set; }

    }
}
