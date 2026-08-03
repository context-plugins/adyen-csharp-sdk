using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>amountMinMaxRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type810>))]
public sealed record Type810 : StringEnum<Type810>
{
    private Type810(string value) : base(value)
    {
    }

    public static readonly Type810 AmountMinMaxRequirement = new("amountMinMaxRequirement");

    public static Type810 FromValue(string value) => FromValueCore(value);
}
