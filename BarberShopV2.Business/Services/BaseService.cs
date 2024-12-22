using BarberShopV2.Business.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Services
{
    public abstract class BaseService
    {
        protected bool ExecutaValidacao<TV, TE>(TV validation,TE entity) 
            where TV : AbstractValidator<TE> 
            where TE : Entity
        {
            var validator = validation.Validate(entity);

            if(validator.IsValid)
            {
                return true;
            }
            else { return false; }
        }
    }
}
