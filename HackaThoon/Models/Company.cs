using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.ImageUrl)]
        public string Wallpaper { get; set; }

        [Required, DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }
        public CompanyType CompanyType { get; set; }

        [Required, DataType(DataType.PhoneNumber), StringLength(10)]
        public  string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Website { get; set; }

        public IEnumerable<Company_Language> Company_Languages { get; set; }
        public Overview Overview { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
