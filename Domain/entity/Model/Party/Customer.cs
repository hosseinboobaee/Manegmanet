using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Party
{
    public class Customer: BaseEntity
    {
        public long? PartyId { get; set; }
        public virtual Party Party { get; set; }
    }
}
