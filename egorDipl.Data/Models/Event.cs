using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egorDipl.Data.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int OrganizerId { get; set; }
        public Company? Organizer { get; set; }
        public int SponsorId { get; set; }
        public Company? Sponsor { get; set; }
        public int StatusId { get; set; }
        public EventStatus? Status { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Cooperation>? Cooperations { get; set; }
        public ICollection<RequestForCooperation>? RequestsForCooperation { get; set; }
    }
}
