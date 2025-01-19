using BarberShopV2.Business.Models;
using BarberShopV2.Business.Enums;

namespace BarberShopV2.Business.Interfaces
{
    public interface IProfessionalRepository : IRepository<Professional>
    {
        Task<IEnumerable<Professional>> GetByName(string Name);
        Task<IEnumerable<Professional>> GetByGender(Gender gender);
    }
}
