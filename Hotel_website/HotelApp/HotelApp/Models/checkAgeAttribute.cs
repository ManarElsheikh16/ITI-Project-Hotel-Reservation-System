using System;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    internal class checkAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int age = int.Parse(value.ToString());
            if (value != null)
            {
                if (age >= 20)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("age must be above 20 years");
                }
            }
            return new ValidationResult("age must be above 20 years");

        }
    }
}