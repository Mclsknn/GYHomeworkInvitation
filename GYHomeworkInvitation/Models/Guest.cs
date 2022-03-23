using System.ComponentModel.DataAnnotations;

namespace GYHomeworkInvitation.Models
{
    public class Guest
    {
        [Required(ErrorMessage ="İsim boş geçilemez")]
        [MinLength(2,ErrorMessage ="İsim 2 karakterden az olmamalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim boş geçilemez")]
        [MinLength(2, ErrorMessage = "Soyisim 2 karakterden az olmamalıdır")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email boş geçilemez")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(05(\d{9}))$", ErrorMessage = "Geçersiz telefon numarası")]
        public string PhoneNumber { get; set; }
        public bool WillCome { get; set; }
    }
}
