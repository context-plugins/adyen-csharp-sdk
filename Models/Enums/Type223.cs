using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>noLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type223>))]
public sealed record Type223 : StringEnum<Type223>
{
    private Type223(string value) : base(value)
    {
    }

    public static readonly Type223 NoLocal = new("noLocal");

    public static Type223 FromValue(string value) => FromValueCore(value);
}
