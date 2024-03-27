using System.ComponentModel.DataAnnotations;

namespace AspNet_1_Assignment.Models;

public class AccountDetailsViewModel
{
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName {get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName {get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    public string Email {get; set; } = null!;

}

