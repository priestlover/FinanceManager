using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace FinanceManager.Persistence.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}
