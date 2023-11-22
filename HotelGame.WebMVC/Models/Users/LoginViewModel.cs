using System.ComponentModel.DataAnnotations;

namespace HotelGame.WebMVC.Models.Users
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Lütfen Eposta Hesabınızı Giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

    }
}
