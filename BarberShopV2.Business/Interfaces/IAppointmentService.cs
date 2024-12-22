using BarberShopV2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Interfaces
{
    public interface IAppointmentService 
    {
        Task Add(Appointment appointment);
        Task Update(Appointment appointment);
        Task Delete(Guid id);
    }
}
