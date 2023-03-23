using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheel.Domain.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
