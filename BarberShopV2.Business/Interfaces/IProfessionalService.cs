using BarberShopV2.Business.Models;

namespace BarberShopV2.Business.Interfaces
{
    public interface IProfessionalService 
    {
        Task Add(Professional professional);
        Task Update(Professional professional);
        Task Delete(Guid id);
    }
}
