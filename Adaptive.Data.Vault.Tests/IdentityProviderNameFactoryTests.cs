using Adaptive.Data.Vault;
using Xunit;

public class IdentityProviderNameFactoryTests
{
    [Theory]
    [InlineData(IdentityProviderType.Apple, "Apple")]
    [InlineData(IdentityProviderType.Microsoft, "Microsoft")]
    [InlineData(IdentityProviderType.Facebook, "Facebook")]
    [InlineData(IdentityProviderType.CorporateCustomOrOther, "Corporate, Custom, Or Other")]
    [InlineData(IdentityProviderType.Google, "Google")]
    [InlineData((IdentityProviderType)999, "Unknown")]
    public void GetProviderTypeName_ReturnsExpectedName(IdentityProviderType type, string expected)
    {
        var result = IdentityProviderNameFactory.GetProviderTypeName(type);
        Assert.Equal(expected, result);
    }
}