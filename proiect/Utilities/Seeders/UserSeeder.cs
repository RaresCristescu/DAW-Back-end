using proiect.Data;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities.Seeders
{
    public class UserSeeder
    {
        public readonly ProiectContext _context;
        public UserSeeder(ProiectContext context)
        {
            _context = context;
        }
        public void SeedInitialUsers()
        {
            if (!_context.Users.Any())
            {
                var user = new User
                {
                    FirstName = "",
                    LastName = "",
                    UserName="",
                    Email="",
                    IsDeleted = false
                };
                _context.Add(user);
                _context.SaveChanges();
            }
        }
    }
}
