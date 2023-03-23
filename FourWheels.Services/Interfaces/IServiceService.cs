using FourWheel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Services.Interfaces
{
    public interface IServiceService
    {


        Task<List<Case>> GetAllServices();
        Task<List<Customer>> GetAllCustomers();

    }
}
