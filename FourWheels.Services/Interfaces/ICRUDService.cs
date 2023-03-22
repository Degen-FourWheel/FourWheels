using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Services.Interfaces
{
    public interface ICRUDService
    {
        Task CreateEntity<T>(T Entry) where T : class;
        Task UpdateEntry<T>(T Entry) where T : class;
        Task DeleteEntry<T>(T Entry) where T : class;

    }
}
