using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Party
{
    public class Customer:BaseEntity
    {
        public string FullName { get; set; }
        public long? PartyId { get; set; }
        public Party Party { get; set; }
    }
}
