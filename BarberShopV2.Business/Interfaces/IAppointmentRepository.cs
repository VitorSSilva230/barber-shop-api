using BarberShopV2.Business.Models;

namespace BarberShopV2.Business.Interfaces
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Task<IEnumerable<Appointment>> GetByCostumerID(Guid costumerId);
        Task<IEnumerable<Appointment>> GetByProfessionalID(Guid professionalId);
    }
}
