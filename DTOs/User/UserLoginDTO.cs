﻿namespace dotnet_rpg.DTOs.User
{
    public class UserLoginDTO
    {
        public UserLoginDTO()
        {
            Username = string.Empty;
            Password = string.Empty;

        }
         
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
