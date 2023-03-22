using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheel.Domain.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarManufacturer { get; set; }
        public string CarModel { get; set; }
        public string LicensePlate { get; set; }
        public double KMStanding { get; set; }

        public Customer Customer { get; set; }
    }
}
