using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Item
{
    public class ReserveItem:BaseEntity
    {
        public long? ReserveId { get; set; }
        public virtual Reserve Reserve { get; set; }
        public long? ItemId { get; set; }
        public virtual Item Item{ get; set; }
    }
}
