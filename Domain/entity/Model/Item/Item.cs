using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Item
{
    public class Item:BaseEntity
    {
        public string Title { get; set; }
        public virtual Category Category { get; set; }
    }
}
