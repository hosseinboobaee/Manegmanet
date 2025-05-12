using Domain.entity.Model.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Order
{
    public class Reserve : AuditableEntity
    {
        public long CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public virtual Customer Customer { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<ReserveItem> ReserveItems { get; set; }
    }
}
