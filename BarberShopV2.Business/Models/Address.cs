namespace BarberShopV2.Business.Models
{
    public class Address : Entity
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? Neighborhood { get; set; }
        public string? PostalCode { get; set; }
        public string? Complement { get; set; }

    }
}
