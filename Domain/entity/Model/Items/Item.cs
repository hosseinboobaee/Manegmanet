using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Items
{
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public bool IsActive { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
