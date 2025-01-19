using System.ComponentModel.DataAnnotations;

namespace BarberShopV2.API.DTO
{
    public class AddressDTO
    {
        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} carateres", MinimumLength = 3)]
        public string? City { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} carateres", MinimumLength = 3)]
        public string? State { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} carateres", MinimumLength = 3)]
        public string? Street { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        
        public int Number { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} carateres", MinimumLength = 3)]
        public string? Neighborhood { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} deve ter exatamente {1} carateres")]
        public string? PostalCode { get; set; }

        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} carateres", MinimumLength = 3)]
        public string? Complement { get; set; }
    }
}
