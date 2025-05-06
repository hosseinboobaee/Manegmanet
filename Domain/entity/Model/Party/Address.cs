using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Party
{
    public class Address:BaseEntity
    {
        public string Title { get; set; }
        public long? UserId { get; set; }
        public  virtual User User { get; set; }
    }
}
