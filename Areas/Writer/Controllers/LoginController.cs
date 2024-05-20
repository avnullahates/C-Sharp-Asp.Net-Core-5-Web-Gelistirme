using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;
        private readonly UserManager<WriterUser> _userManager;
        private readonly IPasswordHasher<WriterUser> passwordHasher;

        public LoginController(SignInManager<WriterUser> signInManager, UserManager<WriterUser> userManager, IPasswordHasher<WriterUser> passwordHasher)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            this.passwordHasher = passwordHasher;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("ProfileIndex", "Profile");
                }
                else
                {
                    ModelState.AddModelError("UserName", "Hatali Kullanici Adi veya Sifre");
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        //Context db = new Context();

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(PasswordVM passwordVM)
        {

            WriterUser personnel = await _userManager.FindByEmailAsync(passwordVM.Email);

            //var model = db.Users.FirstOrDefault(x => x.Email == passwordVM.Email);

            if (personnel != null)
            {
          
                Guid guid = Guid.NewGuid();
                string newPassword = guid.ToString().Substring(0, 8);
                passwordVM.NewPassword = newPassword;
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(Mail.mail, Mail.sifre);
                client.Port = 587;
                client.Host = "smtp-mail.outlook.com";
                client.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.To.Add(personnel.Email);
                mail.From = new MailAddress(Mail.mail, "Şifre Yenileme");
                mail.IsBodyHtml = true;
                mail.Subject = "Şifre Sıfırlama";
                mail.Body += "Merhaba Sayın " + personnel.Name + " " + personnel.Surname + "<br/> Kullanıcı Adınız = " + personnel.UserName + "<br/> Şifreniz: " + newPassword;

                client.Send(mail);
          
                personnel.PasswordHash = passwordHasher.HashPassword(personnel, passwordVM.NewPassword);

                IdentityResult Iresult = await _userManager.UpdateAsync(personnel);

                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.Message = "Mail bulunamadı";
                return View(personnel);
            }

        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
