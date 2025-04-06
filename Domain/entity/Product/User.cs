using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Product
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty; // هش‌شده، نه plain text

        public string Role { get; set; } = "Staff"; // Admin, Staff

        // اگر بخوای وصلش کنی به کارمند مربوطه:
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
