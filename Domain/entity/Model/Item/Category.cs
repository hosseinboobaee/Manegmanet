using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Item
{
    public class Category: AuditableEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
