using Domain.entity.Model.Party;
using Domain.entity.Model.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model.Order
{
    public class OrderDetail : BaseEntity
    {
        [Display(Name = "سفارش")]
        public long OrderId { get; set; }
        [Display(Name = "خدمت")]
        public long ItemId { get; set; } // نوع خدمت
        [Display(Name = "ارائه‌دهنده خدمت")]
        public long? PerformedByUserId { get; set; }
        [Display(Name = "قیمت واحد")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "تخفیف")]
        public decimal Discount { get; set; }
        [Display(Name = "مبلغ نهایی")]
        public decimal FinalPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Item Items { get; set; }
        public virtual User PerformedByUser { get; set; }
    }
}
