using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Id cannot be empty")]
        public int Id { get; set; }
        [MyValidation(ErrorMessage ="Invalid entry for name")]
        public string Name { get; set; }
        [Range(18,56,ErrorMessage ="Invalid Age")]
        public int Age { get; set; }
        [EmailAddress]
        public string EMail { get; set; }

        public string Phone { get; set; }
        [Required(ErrorMessage ="Password cannot be empty")]
        [RegularExpression("[a-zA-Z][a-zA-Z]*")]
        public string Password { get; set; }
    }
}
