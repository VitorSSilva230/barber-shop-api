using BarberShopV2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Interfaces
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Task<IEnumerable<Appointment>> GetByCostumerID(Guid costumerId);
        Task<IEnumerable<Appointment>> GetByProfessionalID(Guid professionalId);
    }
}
