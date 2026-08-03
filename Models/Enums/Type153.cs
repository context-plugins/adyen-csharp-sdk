using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>caLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type153>))]
public sealed record Type153 : StringEnum<Type153>
{
    private Type153(string value) : base(value)
    {
    }

    public static readonly Type153 CaLocal = new("caLocal");

    public static Type153 FromValue(string value) => FromValueCore(value);
}
