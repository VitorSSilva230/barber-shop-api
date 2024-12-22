using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopV2.Business.Enums
{
    public enum Status
    {
        Scheduled = 1,      
        InProgress = 2,     
        Completed = 3,      
        Canceled = 4,       
        NoShow = 5,         
        Rescheduled = 6  
    }
}
