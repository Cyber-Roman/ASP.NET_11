using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreConsultationForm.Settings
{
    public class NotWeekendAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
