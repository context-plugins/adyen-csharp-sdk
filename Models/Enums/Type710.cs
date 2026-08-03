using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>addressRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type710>))]
public sealed record Type710 : StringEnum<Type710>
{
    private Type710(string value) : base(value)
    {
    }

    public static readonly Type710 AddressRequirement = new("addressRequirement");

    public static Type710 FromValue(string value) => FromValueCore(value);
}
