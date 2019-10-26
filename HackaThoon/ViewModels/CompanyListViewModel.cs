using HackaThoon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.ViewModels
{
    public class CompanyListViewModel
    {
        public IEnumerable<Company> Companies { get; set; }
        public Company Company { get; set; }
        public CompanyType CompanyType { get; set; }

        public string SearchKeyword { get; set; }

        public Overview Overview { get; set; }
       // public IEnumerable<Language> Languages { get; set; }
    }
}
