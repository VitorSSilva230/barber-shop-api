using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BarberShopV2.Business.Enums;

namespace BarberShopV2.Business.Models
{
    public class Appointment : Entity
    {
        public Customer? Costumer { get; set; }
        public Professional? Professional { get; set; }
        public Status Status { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime Registration { get; set; } = DateTime.Now;
    }
}
