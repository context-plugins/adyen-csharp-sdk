using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RequiredAddressField>))]
public sealed record RequiredAddressField : OpenStringEnum<RequiredAddressField>
{
    private RequiredAddressField(string value) : base(value)
    {
    }

    public static readonly RequiredAddressField City = new("city");

    public static readonly RequiredAddressField Country = new("country");

    public static readonly RequiredAddressField Line1 = new("line1");

    public static readonly RequiredAddressField PostalCode = new("postalCode");

    public static readonly RequiredAddressField StateOrProvince = new("stateOrProvince");

    public TResult Match<TResult>(Func<TResult> onCity,
        Func<TResult> onCountry,
        Func<TResult> onLine1,
        Func<TResult> onPostalCode,
        Func<TResult> onStateOrProvince,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == City => onCity(),
            _ when this == Country => onCountry(),
            _ when this == Line1 => onLine1(),
            _ when this == PostalCode => onPostalCode(),
            _ when this == StateOrProvince => onStateOrProvince(),
            _ => otherwise(Value)
        };

    public void Match(Action onCity,
        Action onCountry,
        Action onLine1,
        Action onPostalCode,
        Action onStateOrProvince,
        Action<string> otherwise)
    {
        if (this == City) onCity();
        else if (this == Country) onCountry();
        else if (this == Line1) onLine1();
        else if (this == PostalCode) onPostalCode();
        else if (this == StateOrProvince) onStateOrProvince();
        else otherwise(Value);
    }
}
