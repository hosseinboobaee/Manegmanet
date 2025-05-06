using Domain.entity.Model.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Party
{
    public class User : AuditableEntity
    {
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public long PartyId { get; set; }
        public virtual Party Party { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }

    }
}
