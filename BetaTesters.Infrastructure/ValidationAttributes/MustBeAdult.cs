using System.ComponentModel.DataAnnotations;

namespace BetaTesters.Infrastructure.ValidationAttributes
{
    public class MustBeAdult : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value == null)
            {
                return false;
            }

            int age = (int)value;

            if(age < 18)
                return false;

            return true;
        }
    }
}
