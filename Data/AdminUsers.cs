﻿using ReaiotBackend.Constants;
using ReaiotBackend.Models;

namespace ReaiotBackend.Data
{
    public static class AdminUsers
    {
        public static AppUser Admins = new AppUser()
        {
            PasswordHash = "2288Shiks.",
            UserName = "Humphryshikunzi",
            Email = "humphry.shikunzi@outlook.com",
            Role = Roles.Admin
        };
    }
}
