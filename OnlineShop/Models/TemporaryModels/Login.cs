﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models.TemporaryModels
{
    public class Login
    {
        [Required(ErrorMessage = "The field is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The string must be between 50 and 3 symbols")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The string must be between 50 and 3 symbols")]
        public string Password { get; set; }
    }
}