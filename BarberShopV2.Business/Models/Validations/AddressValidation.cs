using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Models.Validations
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation() 
        {
            RuleFor(r => r.City)
               .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
               .Length(3, 100).WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");

            RuleFor(r => r.State)
               .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
               .Length(3, 100).WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");

            RuleFor(r => r.Street)
               .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
               .Length(3, 100).WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");

            RuleFor(r => r.Neighborhood)
               .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
               .Length(3, 100).WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");

            RuleFor(r => r.PostalCode)
               .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
               .Length(8).WithMessage("O campo {PropertyName} deve ter {MaxLenght} caracteres");

            RuleFor(r => r.Complement)
               .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
               .Length(3, 100).WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");



        }
    }
}
