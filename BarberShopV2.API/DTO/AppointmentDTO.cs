

using System.ComponentModel.DataAnnotations;

namespace BarberShopV2.API.DTO
{
    public class AppointmentDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        public Guid CostumerId { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        public Guid ProfessionalId { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        public string? Status { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        public DateTime ScheduledTime { get; set; }
        public DateTime Registration { get; set; }

        public string? NameCostumer { get; set; }
        public string? NameProfessional { get; set; }
    }
}
