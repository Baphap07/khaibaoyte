using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.ViewModels
{
    public class CreateSymptom
    {

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
    }
}
