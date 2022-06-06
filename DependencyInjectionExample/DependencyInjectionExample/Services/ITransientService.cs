using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Services
{
    public interface ITransientService
    {
        Guid GetID();
    }
}
