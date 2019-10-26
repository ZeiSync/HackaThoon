using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public bool Rate { get; set; }
        public string Comment { get; set; }
        public string Suggest { get; set; }
    }
}
