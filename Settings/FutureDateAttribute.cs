using System.ComponentModel.DataAnnotations;

namespace AspNetCoreConsultationForm.Settings
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "The desired date should be in the future and not fall on a weekend!";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                // Перевірка чи дата в майбутньому
                if (date.Date <= DateTime.Now.Date)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }

                // Перевірка чи дата не є вихідним днем
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }

                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid date type.");
        }
    }
}
