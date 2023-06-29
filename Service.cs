using LifetimeServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimeServices
{
    public class Service:ISingleton,ITransient,IScoped
    {
        Guid id;
        public Service()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
