using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Party
{
    public class Phone:BaseEntity
    {
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public long? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public long? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
