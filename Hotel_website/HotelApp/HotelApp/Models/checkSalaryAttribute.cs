using System;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    internal class checkSalaryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var salary = double.Parse(value.ToString());
            if (value != null)
            {
                if (salary > 0)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("salary must be positive and not equal zero");
                }
            }
            return new ValidationResult("salary must be positive and not equal zero");
        }
    }
}