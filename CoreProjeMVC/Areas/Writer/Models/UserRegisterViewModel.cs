using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lutfen  adini giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lutfen  soyadini giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lutfen  image giriniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lutfen Kullanici adini giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen sifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lutfen sifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Sifreler uyumlu degil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lutfen mail giriniz")]
        public string Mail { get; set; }


    }
}
