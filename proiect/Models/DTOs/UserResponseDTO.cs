﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models.DTOs
{
    public class UserResponseDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public UserResponseDTO(User user,string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Email = user.Email;
            Token = token;

        }
    }
}
