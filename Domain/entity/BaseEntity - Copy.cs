using Domain.entity.Model.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity
{
    public abstract class AuditableEntity : BaseEntity
    {
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
