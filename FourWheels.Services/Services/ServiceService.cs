using FourWheel.Domain.Data;
using FourWheel.Domain.Models;
using FourWheels.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Services.Services
{
    public class ServiceService : IServiceService
    {

        private readonly FourWheelsDBContext _context;

        public ServiceService(FourWheelsDBContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetAllCustomers() => await _context.Customers.Include(x => x.Cars).ToListAsync() ;

        public async Task<List<Case>> GetAllServices() => await _context.Services.Include(x => x.Customer).ThenInclude(x => x.Cars).ToListAsync();


    }
}
