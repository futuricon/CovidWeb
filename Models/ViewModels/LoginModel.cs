﻿using System.ComponentModel.DataAnnotations;

namespace CovidWeb.Models.ViewModels {

    public class LoginModel {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
