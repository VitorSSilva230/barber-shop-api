using System.ComponentModel.DataAnnotations;

namespace BarberShopV2.API.DTO
{
    public class ProfessionalDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime Registration { get; set; } 
        public bool Active { get; set; }

        public AddressDTO? Address { get; set; }
        public IEnumerable<AppointmentDTO>? Appointments { get; set; }
    }
}
