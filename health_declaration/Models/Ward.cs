using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class Ward
    {
        public int WardId { get; set; }
        [Required]
        public string WardName { get; set; }
        [Required]
        public string Prefix { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
    }
}
