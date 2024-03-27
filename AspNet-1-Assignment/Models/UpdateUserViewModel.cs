using System.ComponentModel.DataAnnotations;

namespace AspNet_1_Assignment.Models;

public class UpdateUserViewModel
{
    [Required]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName {get; set; } = null!;

    [Required]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName {get; set; } = null!;
    [Required]
    [Display(Name = "Phone", Prompt = "Enter your phone")]
    [DataType(DataType.PhoneNumber)]
    public string ?PhoneNumber {get; set; }
    [Required]
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    public string Email {get; set; } = null!;

    [Display(Name = "Bio", Prompt = "Add a short bio...")]
    public string Bio {get; set;} = null!;

    public AddressViewModel Address {get; set;} = null!;
}

