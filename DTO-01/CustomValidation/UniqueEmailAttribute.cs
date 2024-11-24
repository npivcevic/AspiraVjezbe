using System.ComponentModel.DataAnnotations;

namespace DTO_01.CustomValidation
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            DataContext? dbContext = (DataContext?)validationContext.GetService(typeof(DataContext));

            if (dbContext == null)
            {
                throw new Exception("Error validating email uniquenes. Unable to get database context");
            }
            var email = value.ToString();

            var exists = dbContext.Users.Any(u => u.Email == email);
            if (exists)
            {
                return new ValidationResult("The email address is already in use.");
            }

            return ValidationResult.Success;
        }
    }
}
