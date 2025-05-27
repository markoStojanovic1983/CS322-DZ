using System.ComponentModel.DataAnnotations;

namespace DZ08.Models
{
    public class PublicationYearAttribute : ValidationAttribute
    {
        public PublicationYearAttribute()
        {
            ErrorMessage = "Publication date cannot be in the future and must be after 1000 AD";
        }

        public override bool IsValid(object? value)
        {
            if (value is DateTime dateTime)
            {
                return dateTime <= DateTime.Now && dateTime.Year >= 1000;
            }
            return false;
        }
    }
}