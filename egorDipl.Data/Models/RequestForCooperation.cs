using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egorDipl.Data.Models
{
    public class RequestForCooperation
    {
        public int Id { get; set; }
        public int SenderCompanyId { get; set; }
        public Company? SenderCompany { get; set; }
        public string? TextLetter { get; set; }
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public int StatusId { get; set; }
        public RequestStatus? Status { get; set; }
        public ICollection<Cooperation>? Cooperations { get; set; }
    }
}
