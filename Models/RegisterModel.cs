using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace CP_POS.Models
{
    public class RegisterModel
    {

        [Required]
        public string UserName { get; set; }   
        [Required]
        public string Name { get; set; } 
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
