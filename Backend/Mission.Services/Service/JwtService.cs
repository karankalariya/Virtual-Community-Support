﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Mission.Entities.ViewModel.Login;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.Service
{
    public class JwtService
    {
        public string Key { get; set; }
        public int Duration { get; set; }

        public JwtService(IConfiguration configuration)
        {
            Key = configuration.GetSection("JWTConfig").GetSection("Key").Value;
            Duration = Convert.ToInt32(configuration.GetSection("JWTConfig").GetSection("Duration").Value);
        }

        public string GenerateJwtToken(UserLoginResponseModel loginUser)
        {
            // Create security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
            var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var payload = new[]
            {
                new Claim("userId", loginUser.Id.ToString()),
                new Claim("fullName", $"{loginUser.FirstName} {loginUser.LastName}"),
                new Claim("firstName", loginUser.FirstName),
                new Claim("lastName", loginUser.LastName),
                new Claim("emailAddress", loginUser.EmailAddress),
                new Claim("phoneNumber", loginUser.PhoneNumber),
                new Claim("userType", loginUser.UserType),
                new Claim(ClaimTypes.Role, loginUser.UserType)
            };

            var jwtToken = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: payload,
                expires: DateTime.Now.AddHours(Duration),
                signingCredentials: signature
                );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

    }
}
