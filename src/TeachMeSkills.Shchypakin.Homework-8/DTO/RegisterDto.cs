using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_8.DTO
{
    public class RegisterDto
    {
        [Required]
        public string ClientName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
