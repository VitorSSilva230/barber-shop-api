using BarberShopV2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Interfaces
{
    public interface IProfessionalService 
    {
        Task Add(Professional professional);
        Task Update(Professional professional);
        Task Delete(Guid id);
    }
}
