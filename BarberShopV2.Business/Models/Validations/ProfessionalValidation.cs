using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Models.Validations
{
    public class ProfessionalValidation : AbstractValidator<Professional>
    {
        public ProfessionalValidation() 
        {
            RuleFor(r => r.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido")
                .Length(3, 100).WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");

            RuleFor(r => r.Gender)
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido");
                
        }
    }
}
