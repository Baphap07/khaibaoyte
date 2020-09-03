using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.Models
{
    public class Medical_Declaration
    {
        public int Id { get; set; }
        [Required]
        public int GateId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Dob { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PassportNumber { get; set; }
        [Required]
        public int ProvinceId { get; set; }
        [Required]
        public int DistrictId { get; set; }
        [Required]
        public int WardId { get; set; }
        [Required]
        public int SymptonId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Departure_day { get; set; }
        [Required]
        public DateTime Entry_date { get; set; }
        [Required]
        public string start_place { get; set; }
        [Required]
        public string destination { get; set; }
        [Required]
        public bool Contact_Oj { get; set; }
        [Required]
        public bool Contact_Pp { get; set; }
        public string vacxin { get; set; }

    }
}
