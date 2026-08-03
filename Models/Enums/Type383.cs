using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>usInternationalAchAddressRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type383>))]
public sealed record Type383 : StringEnum<Type383>
{
    private Type383(string value) : base(value)
    {
    }

    public static readonly Type383 UsInternationalAchAddressRequirement = new("usInternationalAchAddressRequirement");

    public static Type383 FromValue(string value) => FromValueCore(value);
}
