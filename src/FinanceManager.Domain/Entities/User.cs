﻿using FinanceManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; } 
       
        public string Name { get; private set; }
       
        public string Email { get; private set; }

        private User() { }

    }
}
