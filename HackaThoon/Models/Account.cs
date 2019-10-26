using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string AccountName  { get; set; }
        [Required, RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$")]
        public string Password { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
    }
}
