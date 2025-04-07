using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model
{
    public class Employee : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // مثل: آرایشگر
        public bool IsActive { get; set; } = true;

        public ICollection<Appointment> Appointments { get; set; }
    }
}
