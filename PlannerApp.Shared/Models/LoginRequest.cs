using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlannerApp.Shared.Models
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength = 0)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
