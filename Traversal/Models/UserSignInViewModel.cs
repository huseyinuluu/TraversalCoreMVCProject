﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage= "Lütfen Kullanıcı Adınızı Giriniz")]
        public string username { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string password { get; set; }
    }
}
