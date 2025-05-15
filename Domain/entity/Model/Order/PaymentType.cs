using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Order
{
    public class PaymentType : BaseEntity
    {
        [Display(Name = "نوع پرداخت")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
