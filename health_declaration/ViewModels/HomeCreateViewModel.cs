using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required]
        [Range(1,10000,ErrorMessage = "Hãy Chọn Cửa Khẩu")]
        public int GateId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Dob { get; set; }
        [Required]
        [Range(1, 3, ErrorMessage = "Hãy chọn giới tính")]
        public int Gender { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PassportNumber { get; set; }
        [Required]
        [Range(1, 2000, ErrorMessage = "Hãy chọn Tỉnh")]
        public int ProvinceId { get; set; }
        [Required]
        [Range(1, 2000, ErrorMessage = "Hãy chọn Quận/Huyện")]
        public int DistrictId { get; set; }
        [Required]
        [Range(1, 10000, ErrorMessage = "Hãy chọn Phường/Xã")]
        public int WardId { get; set; }
        
        public int SymptonId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required(ErrorMessage = "Hãy Chọn Ngày")]
        public DateTime Departure_day { get; set; }
        [Required(ErrorMessage = "Hãy Chọn Ngày")]
        public DateTime Entry_date { get; set; }
        [Required]
        [Range(1, 2000, ErrorMessage = "Hãy chọn Tỉnh")]
        public string Start_Place { get; set; }
        [Required]
        [Range(1, 2000, ErrorMessage = "Hãy chọn Tỉnh")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Hãy chọn ô Sốt. ")]
       
        public bool Sot { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Ho ")]
        public bool Cough { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Khó thở. ")]
        public bool Sob { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Đau họng. ")]
        public bool Sorethroat { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Nôn/buồn nôn. ")]
        public bool Nausea { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Tiêu chảy. ")]
        public bool Diarhea { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Xuất huyết ngoài da. ")]
        public bool Bots { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô Nổi ban ngoài da. ")]
        public bool Skinrash { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô . ")]
        public bool Contact_Oj { get; set; }
        [Required(ErrorMessage = "Hãy chọn ô . ")]
        public bool Contact_Pp{ get; set; }
        public string Vacxin { get; set; }
    }
}
