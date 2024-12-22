using BarberShopV2.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Models
{
    public class Professional : Entity
    {
       
        public string? Name { get; set; }
        public Address? Address { get; set; }
        public Gender Gender { get; set; }
        public DateTime Registration { get; set; } = DateTime.Now;
        public bool Active { get; set; }
    }
}
