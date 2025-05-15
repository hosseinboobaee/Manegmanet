using Domain.entity.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Party
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public long PartyId { get; set; }
        public int? UserType { get; set; }
        public bool IsActive {  get; set; }
        public GenderEnum Gender { get; set; }
        public virtual Party Party { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }

    }
    public enum GenderEnum
    {
        Male = 0,   // آقا
        Female = 1  // خانم
    }
}
