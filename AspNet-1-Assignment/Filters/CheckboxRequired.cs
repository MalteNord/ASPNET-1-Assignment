using System.ComponentModel.DataAnnotations;

namespace AspNet_1_Assignment.Filters;

public class CheckboxRequired : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is bool b && b;
    }

}
