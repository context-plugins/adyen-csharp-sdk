using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>amountNonZeroDecimalsRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type94>))]
public sealed record Type94 : StringEnum<Type94>
{
    private Type94(string value) : base(value)
    {
    }

    public static readonly Type94 AmountNonZeroDecimalsRequirement = new("amountNonZeroDecimalsRequirement");

    public static Type94 FromValue(string value) => FromValueCore(value);
}
