using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Models
{
    public class Company_Language
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
