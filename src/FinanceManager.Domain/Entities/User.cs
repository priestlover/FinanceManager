﻿using FinanceManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Entities
{
    internal class User
    {
        public Guid Id { get; private set; } 
       
        public string Name { get; private set; }
       
        public string Email { get; private set; }
       
        public string ProfilePictureUrl { get; private set; }

        public UserRole Role { get; private set; }

        private User() { }

        public User(string name, string email, UserRole role, string profilepicrureulr) { 
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Role = role;
            ProfilePictureUrl = profilepicrureulr;
        }
    }
}
