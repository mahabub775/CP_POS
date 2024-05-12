using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CP_POS.Models
{

    public class ChangePasswordModel 
    {
        [Required]
        public string userId { get; set; }
        public string currentPassword { get; set; }
        public string newPassword { get; set; }


    }
}
