using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecoplastol.WebUI.Models
{
    public class LoginPageViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Maszyna")]
        public string Maszyna { get; set; }

        [Required]
        [Display(Name = "Zmiana")]
        public string Zmiana { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}