﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egorDipl.Data.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int AboutCompanyId { get; set; }
        public Company? AboutCompany { get; set; }
        public int StarsCount { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }
    }
}
