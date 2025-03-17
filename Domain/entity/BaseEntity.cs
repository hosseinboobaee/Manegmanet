using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreteDate { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public int? LastModoifyBy { get; set; }
    }
}
