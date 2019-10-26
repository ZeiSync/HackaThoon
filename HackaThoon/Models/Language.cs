using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Company_Language> Company_Languages { get; set; }
    }
}
