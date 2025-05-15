using Domain.entity.Model.Party;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Order
{
    public class Order : AuditableEntity
    {
        [Display(Name = "مشتری")]
        public long CustomerId { get; set; }
        [Display(Name = "رزرو مرتبط")]
        public long? ReserveId { get; set; }
        [Display(Name = "تاریخ سفارش")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "مبلغ کل")]
        public decimal TotalAmount { get; set; }
        [Display(Name = "تخفیف")]
        public decimal DiscountAmount { get; set; }
        [Display(Name = "مبلغ قابل پرداخت")]
        public decimal PayableAmount { get; set; }
        [Display(Name = "مبلغ پرداخت‌شده")]
        public decimal PaidAmount { get; set; }
        [Display(Name = "وضعیت سفارش")]
        public OrderStatus Status { get; set; } // Pending, Paid, Cancelled

        public virtual Customer Customer { get; set; }
        public virtual Reserve Reserve { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
    public enum OrderStatus
    {
        Pending = 0,
        Paid = 1,
        Cancelled = 2,
        PartiallyPaid = 3
    }
}
