using System.ComponentModel.DataAnnotations;

namespace BackEnd.CustomValidations
{
    public class NumberIDCardValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object? value,
            ValidationContext validationContext
        )
        {
            if (value is not string input)
            {
                return new ValidationResult("Input is not a string");
            }

            if (input.Length != 15)
            {
                return new ValidationResult("Input must be 15 digits");
            }

            return ValidationResult.Success;
        }
    }
}
