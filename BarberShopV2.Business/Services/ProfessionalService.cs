using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Models;
using BarberShopV2.Business.Models.Validations;

namespace BarberShopV2.Business.Services
{
    public class ProfessionalService : BaseService, IProfessionalService
    {
        private IProfessionalRepository _professionalRepository;

        public ProfessionalService(IProfessionalRepository professionalRepository)
        {
            _professionalRepository = professionalRepository;
        }

        public async Task Add(Professional professional)
        {
            if (!ExecutaValidacao(new ProfessionalValidation(), professional)) return;
            await _professionalRepository.Add(professional);
        }

        public async Task Update(Professional professional)
        {
            if (!ExecutaValidacao(new ProfessionalValidation(), professional)) return;
            await _professionalRepository.Update(professional);
        }

        public async Task Delete(Guid id)
        {
            await _professionalRepository.Delete(id);
        }
    }
}
