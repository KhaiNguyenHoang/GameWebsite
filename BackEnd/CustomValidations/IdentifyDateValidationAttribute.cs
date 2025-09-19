using System.ComponentModel.DataAnnotations;
using BackEnd.Models;

namespace BackEnd.CustomValidations;

public class IdentifyDateValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        var IDCard = validationContext.ObjectInstance as IDCard;
        if (IDCard == null)
        {
            return new ValidationResult("IDCard is null");
        }

        if (IDCard.ExpireDate < DateTime.UtcNow)
        {
            return new ValidationResult("ExpireDate is expired");
        }

        if (IDCard.IssueDate > DateTime.UtcNow)
        {
            return new ValidationResult("IssueDate is not issued");
        }

        if (IDCard.Birthday < IDCard.IssueDate.AddYears(18))
        {
            return new ValidationResult("Birthday is too young");
        }

        return ValidationResult.Success!;
    }
}
