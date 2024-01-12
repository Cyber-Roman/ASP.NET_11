using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class NotOnMondayAttribute : ValidationAttribute, IClientModelValidator
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var selectedProduct = validationContext.ObjectInstance.GetType().GetProperty("SelectedProduct").GetValue(validationContext.ObjectInstance, null);
        var consultationDate = (DateTime)value;

        if (selectedProduct != null && selectedProduct.ToString() == "Основи" && consultationDate.DayOfWeek == DayOfWeek.Monday)
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }

    public void AddValidation(ClientModelValidationContext context)
    {
        context.Attributes.Add("data-val-notonmonday", ErrorMessage);
    }
}
