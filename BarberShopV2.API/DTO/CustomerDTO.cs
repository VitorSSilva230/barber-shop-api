
using BarberShopV2.API.DTO;
using System.ComponentModel.DataAnnotations;

namespace BarberShopV2.API.ViewModels
{
    public class CustomerDTO
    {
        public Guid Id { get; set; }

        [Required (ErrorMessage = "O campo {0} é obrigatório")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Email { get; set; }

        public string? Gender { get; set; }

        public DateTime Registration { get; set; }

        public bool Active { get; set; }

        public AddressDTO? Address { get; set; }

        public IEnumerable<AppointmentDTO>? Appointments { get; set; }
    }
}
