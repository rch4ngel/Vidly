using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class StockRangeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Movie = (Movie)validationContext.ObjectInstance;

            if (Movie.NumberInStock < 1 ||
                Movie.NumberInStock > 20)
                return new ValidationResult("The field number in stock must be between 1 and 20");
            else
                return ValidationResult.Success;
        }
    }
}