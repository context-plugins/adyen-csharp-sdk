using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>usInstantPayoutAddressRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type373>))]
public sealed record Type373 : StringEnum<Type373>
{
    private Type373(string value) : base(value)
    {
    }

    public static readonly Type373 UsInstantPayoutAddressRequirement = new("usInstantPayoutAddressRequirement");

    public static Type373 FromValue(string value) => FromValueCore(value);
}
