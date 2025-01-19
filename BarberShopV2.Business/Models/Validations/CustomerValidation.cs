using FluentValidation;

namespace BarberShopV2.Business.Models.Validations
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation() 
        {
            RuleFor(r => r.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(3, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLength} caracteres");

            RuleFor(r => r.Email)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .EmailAddress().WithMessage("Por favor, insira um Email válido");

            RuleFor(r => r.Gender)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }

    }
}
