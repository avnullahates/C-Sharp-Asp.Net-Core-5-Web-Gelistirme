using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanici Adi")]
        [Required(ErrorMessage ="Kullanici Adini giriniz")]
        public string UserName { get; set; }


        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Sifrenizi giriniz")]
        public string Password { get; set; }
    }
}
