using AspNetCoreConsultationForm.Settings;
using System;
using System.ComponentModel.DataAnnotations;

public class ConsultationModel
{
    [Required(ErrorMessage = "First and last name are required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "The desired consultation date is required")]
    [DataType(DataType.Date)]
    [FutureDate(ErrorMessage = "The desired date must be in the future")]
    [NotOnMonday(ErrorMessage = "The desired date must not be a weekend")]
    public DateTime ConsultationDate { get; set; }

    [Required(ErrorMessage = "Please select a product")]
    public string SelectedProduct { get; set; }
}
