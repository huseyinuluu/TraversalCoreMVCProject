using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Lütfen Soyadınız Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }
                        
        [Required(ErrorMessage ="Lütfen E-Mail Giriniz")]
        public string EMail { get; set; }
        
        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
        
        [Required(ErrorMessage ="Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage ="Şifreler Eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
