using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Model
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public string PaymentType { get; set; } = "Cash"; // Cash, Card, Online
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
