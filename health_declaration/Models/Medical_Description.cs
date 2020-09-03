using System;
namespace health_declaration.Models
{
    public class Medical_Description
    {
        public int Id { get; set; }
        public int GateId { get; set; }
        public string UserName { get; set; }
        public int Dob { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PassportNumber { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int WardId { get; set; }
        public int SymptonId { get; set; }
        public string Description { get; set; }
        public DateTime Departure_day { get; set; }
        public DateTime Entry_date { get; set; }
        public string Start_place { get; set; }
        public string Destination { get; set; }
        public bool Contact_Oj { get; set; }
        public bool Contact_Pp { get; set; }
        public string Vacxin { get; set; }
    }
}
