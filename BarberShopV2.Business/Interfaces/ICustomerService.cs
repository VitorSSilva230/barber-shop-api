using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopV2.Business.Models;

namespace BarberShopV2.Business.Interfaces
{
    public interface ICustomerService : IDisposable
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(Guid id);
    }
}
