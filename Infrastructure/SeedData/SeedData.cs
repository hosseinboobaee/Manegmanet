using Domain.entity.Model.Order;
using Domain.entity.Model.Party;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SeedData
{
    public class SeedData
    {
        private readonly DataContext _context;
        public SeedData(DataContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            SeedUser();
        }
        public void SeedUser()
        {
            if (!_context.Users.Any(u => u.Username == "admin"))
            {
                var adminParty = new Party
                {
                    FirstName = "Admin",
                    LastName = "User"
                };

                _context.Parties.Add(adminParty);
                _context.SaveChanges();
                var passwordHasher = new PasswordHasher<User>();
                var adminUser = new User
                {
                    Username = "admin",
                    PhoneNumber = "09121234567",
                    IsActive = true,
                    UserType = 1,
                    Gender = GenderEnum.Male,
                    PartyId = adminParty.Id
                };
                adminUser.Password = passwordHasher.HashPassword(adminUser, "Admin@123");
                _context.Users.Add(adminUser);
                _context.SaveChanges();
            }
        }
    }
}
