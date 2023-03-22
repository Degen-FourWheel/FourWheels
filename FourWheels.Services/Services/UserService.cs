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
    public class UserService : IUserService
    {
         private readonly FourWheelsDBContext _context;

        public UserService(FourWheelsDBContext context)
        {
            _context= context;
        }

        public async Task<List<Customer>> GetAllAsynx() => await _context.Customers.ToListAsync();
    }
}
