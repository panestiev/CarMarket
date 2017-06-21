﻿namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        [StringLength(10, ErrorMessage = "User name must between 5 and 10 characters", MinimumLength = 5)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(10, ErrorMessage = "Password must between 5 and 10 characters", MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string SelectedCity { get; set; }

        [Required]
        [Display(Name = "Area")]
        public string AreaId { get; set; }
    }
}