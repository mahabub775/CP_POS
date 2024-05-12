using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace CP_POS.Models
{
    public class UserWiseRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string RoleName { get; set; }

    }
}
