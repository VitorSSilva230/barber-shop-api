using AutoMapper;
using BarberShopV2.API.ViewModels;
using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberShopV2.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerRepository customerRepository, ICustomerService customerService, IMapper mapper)
        { 
            _customerRepository = customerRepository;
            _customerService = customerService; 
            _mapper = mapper;
        
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<CustomerDTO>>(await _customerRepository.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CustomerDTO>> GetById(Guid id)
        {
            var customerDTO = await Get(id);

            if (customerDTO == null)
            {
                return NotFound();
            }

            return Ok(customerDTO);
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDTO>> Add(CustomerDTO customerDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var customerAdd = _mapper.Map<Customer>(customerDTO);

            await _customerService.Add(customerAdd);

            return CreatedAtAction(nameof(GetById), new { id = customerAdd.Id }, customerDTO);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, CustomerDTO customerDTO)
        {
            if (id != customerDTO.Id)
            {
                return BadRequest("Os IDS informados não correspondem entre si!");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var customerUpdate = await Get(id);

            // Sem a camada de dados as propriedades da classe ainda não estão sendo retornadas pelo método GET(id)

            //customerUpdate.Name = customerDTO.Name; 
            //customerUpdate.Gender = customerDTO.Gender;
            //customerUpdate.Active = customerDTO.Active;
            //customerUpdate.Address = customerDTO.Address;

            await _customerService.Update(_mapper.Map<Customer>(customerUpdate));

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<CustomerDTO>> Delete(Guid id)
        {
            var customerDel = await Get(id);

            if (customerDel == null) return NotFound(id);

            await _customerService.Delete(id);

            return NoContent();
        }

        private async Task<ActionResult<CustomerDTO>> Get(Guid id)
        {
            var customerGet = await _customerRepository.GetById(id);
            return _mapper.Map<CustomerDTO>(customerGet);
        }
    }
}
