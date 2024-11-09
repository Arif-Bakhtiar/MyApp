﻿using Microsoft.AspNetCore.Identity;

namespace MyApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; } 
    }
}