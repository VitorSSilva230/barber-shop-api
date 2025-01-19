using BarberShopV2.Business.Enums;

namespace BarberShopV2.Business.Models
{
    public class Customer : Entity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Address? Address { get; set; }
        public Gender Gender { get; set; }
        public DateTime Registration { get; set; } = DateTime.Now;
        public bool Active { get; set; }

        public IEnumerable<Appointment> Appointments { get; set; }
    }
}
