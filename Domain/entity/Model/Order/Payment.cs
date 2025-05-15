using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Order
{
    public class Payment : BaseEntity
    {
        [Display(Name = "سفارش")]
        public long OrderId { get; set; }
        [Display(Name = "مبلغ پرداختی")]
        public decimal Amount { get; set; }
        [Display(Name = "تاریخ پرداخت")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "نوع پرداخت")]
        public long PaymentTypeId { get; set; }
        [Display(Name = "شماره پیگیری")]
        public string ReferenceNumber { get; set; } // برای پرداخت آنلاین یا POS
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        public virtual Order Order { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
