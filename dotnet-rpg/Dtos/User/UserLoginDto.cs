﻿using System;
namespace dotnet_rpg.Dtos.User
{
    public class UserLoginDto
    {
        public UserLoginDto()
        {
        }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

