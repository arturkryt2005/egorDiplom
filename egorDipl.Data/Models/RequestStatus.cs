using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egorDipl.Data.Models
{
    public class RequestStatus
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<RequestForCooperation>? RequestsForCooperation { get; set; }
    }
}
