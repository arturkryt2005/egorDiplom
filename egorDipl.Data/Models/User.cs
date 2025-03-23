using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egorDipl.Data.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Post { get; set; }
        public int RoleId { get; set; }
        public StaffRole? Role { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        public ICollection<FeedBack>? FeedBacks { get; set; }
    }
}
