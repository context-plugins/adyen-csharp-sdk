using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RequiredAddressField>))]
public sealed record RequiredAddressField : StringEnum<RequiredAddressField>
{
    private RequiredAddressField(string value) : base(value)
    {
    }

    public static readonly RequiredAddressField City = new("city");

    public static readonly RequiredAddressField Country = new("country");

    public static readonly RequiredAddressField Line1 = new("line1");

    public static readonly RequiredAddressField PostalCode = new("postalCode");

    public static readonly RequiredAddressField StateOrProvince = new("stateOrProvince");

    public static RequiredAddressField FromValue(string value) => FromValueCore(value);
}
