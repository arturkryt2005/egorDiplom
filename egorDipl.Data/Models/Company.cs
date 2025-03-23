using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egorDipl.Data.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int CountEvents { get; set; }
        public int FeedBacksCount { get; set; }
        public int Rating { get; set; }
        public int IsOrganizer { get; set; }
        public int IsSponsor { get; set; }
        public string? Description { get; set; }
        public ICollection<Event>? Events { get; set; }
        public ICollection<Cooperation>? Cooperations { get; set; }
        public ICollection<FeedBack>? FeedBacks { get; set; }
        public ICollection<RequestForCooperation>? RequestsForCooperation { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
