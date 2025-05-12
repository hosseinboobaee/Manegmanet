using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Order
{
    public class Deposit : BaseEntity
    {
        public decimal? Amount { get; set; }
        public long? ReserveId { get; set; }
        public virtual Reserve Reserve { get; set; }
    }
}
