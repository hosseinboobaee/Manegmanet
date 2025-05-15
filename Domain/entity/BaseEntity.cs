using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public bool IsDelete { get; set; }
        public int? CreatedUser { get; set; }
        public int? ModifiedUser { get; set; }
        public DateTime? CreteDate { get; set; }
        public DateTime? LastModifyDate { get; set; }
    }
}
