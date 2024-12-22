using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Models;
using BarberShopV2.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Services
{
    internal class AppointmentService : BaseService, IAppointmentService
    {
        protected IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public async Task Add(Appointment appointment)
        {
           if (!ExecutaValidacao(new AppointmentValidation(), appointment)) return;

            if(_appointmentRepository.Get(a => a.ScheduledTime == appointment.ScheduledTime).Result.Any())
            {
                throw new Exception("Horário indisponível!");
            }

            await _appointmentRepository.Add(appointment);
        }

        public async Task Update(Appointment appointment)
        {
            if (!ExecutaValidacao(new AppointmentValidation(), appointment)) return;

            if (_appointmentRepository.Get(a => a.ScheduledTime == appointment.ScheduledTime).Result.Any())
            {
                throw new Exception("Horário indisponível!");
            }

            await _appointmentRepository.Update(appointment);
        }

        public async Task Delete(Guid id)
        {
            await _appointmentRepository.Delete(id);
        }
    }
}
