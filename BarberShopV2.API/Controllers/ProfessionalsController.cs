using AutoMapper;
using BarberShopV2.API.DTO;
using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberShopV2.API.Controllers
{
    [Route("api/professional")]
    [ApiController]
    public class ProfessionalsController : ControllerBase
    {
        private readonly IProfessionalRepository _professionalRepository;
        private readonly IProfessionalService _professionalService;
        private readonly IMapper _mapper;

        public ProfessionalsController(IProfessionalRepository professionalRepository, IProfessionalService professionalService, IMapper mapper ) 
        { 
            _professionalRepository = professionalRepository;
            _professionalService = professionalService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProfessionalDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<ProfessionalDTO>>(await _professionalRepository.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProfessionalDTO>> GetById(Guid id)
        {
            var professionalDTO = await Get(id);

            if (professionalDTO == null)
            {
                return NotFound();
            }

            return Ok(professionalDTO);
        }

        [HttpPost]
        public async Task<ActionResult<ProfessionalDTO>> Add(ProfessionalDTO professionalDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var professionalAdd = _mapper.Map<Professional>(professionalDTO);

            await _professionalService.Add(professionalAdd);

            return CreatedAtAction(nameof(GetById), new { id = professionalAdd.Id }, professionalDTO); 
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, ProfessionalDTO professionalDTO)
        {
            if(id != professionalDTO.Id)
            {
                return BadRequest("Os IDS informados não correspondem entre si!");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var professionalUpdate = await Get(id);

            // Sem a camada de dados as propriedades da classe ainda não estão sendo retornadas

            //professionalUpdate.Name = professionalDTO.Name; 
            //professionalUpdate.Gender = professionalDTO.Gender;
            //professionalUpdate.Active = professionalDTO.Active;
            //professionalUpdate.Address = professionalDTO.Address;

            await _professionalService.Update(_mapper.Map<Professional>(professionalUpdate));

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProfessionalDTO>> Delete(Guid id)
        {
            var professionalDel = await Get(id);

            if (professionalDel == null) return NotFound(id);

            await _professionalService.Delete(id);

            return NoContent();
            
        }


        private async Task<ActionResult<ProfessionalDTO>> Get(Guid id)
        {
            var professionalGet = await _professionalRepository.GetById(id);
            return _mapper.Map<ProfessionalDTO>(professionalGet);
        }
    }
}
