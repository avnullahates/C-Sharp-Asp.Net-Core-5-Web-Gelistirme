using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class PasswordVM
    {
        public string Email { get; set; }

        public string NormalizedEmail { get; set; }     

        [Required(ErrorMessage = "Lütfen parolanızı girin"), MinLength(6, ErrorMessage = "Parola 6 karakterden az olamaz!")]
        public string NewPassword { get; set; }

        
    }
}
