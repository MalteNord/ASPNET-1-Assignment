using System.ComponentModel.DataAnnotations;

namespace AspNet_1_Assignment.Models;

public class AddressViewModel
{
    [Required]
    [Display(Name = "Address line 1", Prompt = "Enter your address line")]
    public string AddressLine_1 {get; set;} = null!;

    [Display(Name = "Address line 2", Prompt = "Enter your second address line")]
    public string AddressLine_2 {get; set;} = null!;

    [Required]
    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [DataType(DataType.PostalCode)]
    public string PostalCode {get; set;} = null!;

    [Required]
    [Display(Name = "City", Prompt = "Enter your address line")]
    public string City {get; set;} = null!;
}
