using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimeServices.Services
{
   public  interface ITransient
    {
        Guid GetID();
    }
}
