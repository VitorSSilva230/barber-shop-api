using BarberShopV2.Business.Models;
using BarberShopV2.Business.Enums;


namespace BarberShopV2.Business.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
   
        Task<IEnumerable<Customer>> GetByName(string name);
        Task<IEnumerable<Customer>> GetByGender(Gender gender);
    }
}
