using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entity.Product
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDateTime { get; set; }
        public string Status { get; set; } = "Scheduled"; // Scheduled, Done, Canceled

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public Payment? Payment { get; set; }
    }
}
