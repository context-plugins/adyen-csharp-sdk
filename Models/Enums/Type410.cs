using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>internal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type410>))]
public sealed record Type410 : StringEnum<Type410>
{
    private Type410(string value) : base(value)
    {
    }

    public static readonly Type410 Internal = new("internal");

    public static Type410 FromValue(string value) => FromValueCore(value);
}
