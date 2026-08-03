using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>usInternationalAchPriorityRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type393>))]
public sealed record Type393 : StringEnum<Type393>
{
    private Type393(string value) : base(value)
    {
    }

    public static readonly Type393 UsInternationalAchPriorityRequirement = new("usInternationalAchPriorityRequirement");

    public static Type393 FromValue(string value) => FromValueCore(value);
}
