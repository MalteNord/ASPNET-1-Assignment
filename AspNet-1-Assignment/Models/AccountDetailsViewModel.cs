using Infrastructure.Models;

namespace AspNet_1_Assignment.Models;

public class AccountDetailsViewModel
{
    public AccountBasicInfo BasicInfo { get; set; } = null!;
    public AccountAddressInfo AddressInfo { get; set; } = null!;
}