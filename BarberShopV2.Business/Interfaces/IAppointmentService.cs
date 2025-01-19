using BarberShopV2.Business.Models;

namespace BarberShopV2.Business.Interfaces
{
    public interface IAppointmentService 
    {
        Task Add(Appointment appointment);
        Task Update(Appointment appointment);
        Task Delete(Guid id);
    }
}
