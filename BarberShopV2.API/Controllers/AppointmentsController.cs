using AutoMapper;
using BarberShopV2.API.DTO;
using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberShopV2.API.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;
        public AppointmentsController(IAppointmentRepository appointmentRepository, IAppointmentService appointmentService, IMapper mapper) 
        { 
            _appointmentRepository = appointmentRepository;
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AppointmentDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<AppointmentDTO>>(await _appointmentRepository.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AppointmentDTO>> GetById(Guid id)
        {
            var appointmentDTO = await Get(id);

            if (appointmentDTO == null)
            {
                return NotFound();
            }

            return Ok(appointmentDTO);
        }

        [HttpPost]
        public async Task<ActionResult<AppointmentDTO>> Add(AppointmentDTO appointmentDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var appointmentAdd = _mapper.Map<Appointment>(appointmentDTO);

            await _appointmentService.Add(appointmentAdd);

            return CreatedAtAction(nameof(GetById), new { id = appointmentAdd.Id }, appointmentDTO);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, AppointmentDTO appointmentDTO)
        {
            if (id != appointmentDTO.Id)
            {
                return BadRequest("Os IDS informados não correspondem entre si!");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var appointmentUpdate = await Get(id);

            // Sem a camada de dados as propriedades da classe ainda não estão sendo retornadas

            //appointmentUpdate.Name = appointmentDTO.Name; 
            //appointmentUpdate.Gender = appointmentDTO.Gender;
            //appointmentUpdate.Active = appointmentDTO.Active;
            //appointmentUpdate.Address = appointmentDTO.Address;

            await _appointmentService.Update(_mapper.Map<Appointment>(appointmentUpdate));

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<AppointmentDTO>> Delete(Guid id)
        {
            var appointmentDel = await Get(id);

            if (appointmentDel == null) return NotFound(id);

            await _appointmentService.Delete(id);

            return NoContent();
        }

        private async Task<ActionResult<AppointmentDTO>> Get(Guid id)
        {
            var appointmentGet = await _appointmentRepository.GetById(id);
            return _mapper.Map<AppointmentDTO>(appointmentGet);
        }

    }
}
