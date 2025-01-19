using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Models;
using BarberShopV2.Business.Models.Validations;

namespace BarberShopV2.Business.Services
{
    public class CustomerService : BaseService, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) 
        { 
            _customerRepository = customerRepository;
        }
        public async Task Add(Customer customer)
        {
            if (!ExecutaValidacao(new CustomerValidation(), customer)) return;
            await _customerRepository.Add(customer);
        }

        public async Task Update(Customer customer)
        {
            if (!ExecutaValidacao(new CustomerValidation(), customer) ||
                !ExecutaValidacao(new AddressValidation(), customer.Address)) return;
            await _customerRepository.Update(customer);
        }

        public async Task Delete(Guid id)
        {
            await _customerRepository.Delete(id);
        }

        public void Dispose()
        {
           _customerRepository?.Dispose();
        }
    }
}
