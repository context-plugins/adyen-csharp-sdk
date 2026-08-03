using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ukLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type273>))]
public sealed record Type273 : StringEnum<Type273>
{
    private Type273(string value) : base(value)
    {
    }

    public static readonly Type273 UkLocal = new("ukLocal");

    public static Type273 FromValue(string value) => FromValueCore(value);
}
