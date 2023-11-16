using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Ad alanı doldurulmak zorundadır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kullıncı Soyad alanı doldurulmak zorundadır.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı doldurulmak zorundadır.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Kullanıcı Mail alanı doldurulmak zorundadır.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Kullanıcı Şifre alanı doldurulmak zorundadır.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Kullanıcı Şifre alanı doldurulmak zorundadır.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor lütfen kontrol ediniz.")]
        public string ConfirmPassword { get; set; }

    }
}
