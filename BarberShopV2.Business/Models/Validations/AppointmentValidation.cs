using FluentValidation;

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
