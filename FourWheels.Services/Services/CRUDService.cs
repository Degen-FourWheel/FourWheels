using FourWheels.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourWheel.Domain.Data;

namespace FourWheels.Services.Services
{
    public class CRUDService : ICRUDService
    {
        private readonly FourWheelsDBContext _Context;
        
        public async Task CreateEntity<T>(T Entry) where T : class
        {
            using (var context = _Context)
            {
                context.Add(Entry);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteEntry<T>(T Entry) where T : class
        {
            using (var context = _Context)
            {
                context.Remove(Entry);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateEntry<T>(T Entry) where T : class
        {
            using (var context = _Context)
            {
                context.Update(Entry);
                await context.SaveChangesAsync();
            }
        }

    }
}
