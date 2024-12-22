using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Models.Validations
{
    public class AppointmentValidation : AbstractValidator<Appointment>
    {
        public AppointmentValidation() 
        {
            RuleFor(r => r.Status)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
                 
        }
    }
}
