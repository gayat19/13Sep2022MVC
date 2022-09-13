using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class MyValidationAttribute :ValidationAttribute
    {
        public override bool IsValid(Object value)
        {
            return ((string)value).All(Char.IsLetter);
        }
    }
}
