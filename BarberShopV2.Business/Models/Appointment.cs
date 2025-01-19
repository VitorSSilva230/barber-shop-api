using BarberShopV2.Business.Enums;

namespace BarberShopV2.Business.Models
{
    public class Appointment : Entity
    {
        public Guid CostumerId { get; set; }
        public Guid ProfessionalId { get; set; }
        public Customer Costumer { get; set; }
        public Professional Professional { get; set; }
        public Status Status { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime Registration { get; set; } = DateTime.Now;
    }
}
