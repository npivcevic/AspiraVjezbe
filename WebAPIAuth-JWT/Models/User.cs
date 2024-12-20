﻿namespace WebAPIAuth_JWT.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public List<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
