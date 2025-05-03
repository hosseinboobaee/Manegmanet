using Domain.entity.Model.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Item
{
    public class Reserve:BaseEntity
    {
        public long? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public long? UserId  { get; set; }
        public virtual User User { get; set; }
    }
}
