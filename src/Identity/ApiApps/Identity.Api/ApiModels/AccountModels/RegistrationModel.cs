﻿using System.ComponentModel.DataAnnotations;

namespace Identity.Api.ApiModels.AccountModels
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} should be between {2} to {1} characters")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
