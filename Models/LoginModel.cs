using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace CP_POS.Models
{
    public class LoginModel
    {
 
        [Required]
        public string UserName { get; set; } 

        [Required]
        public string Password { get; set; }

    }
}
