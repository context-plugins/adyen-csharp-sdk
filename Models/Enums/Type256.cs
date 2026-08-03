using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>plLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type256>))]
public sealed record Type256 : StringEnum<Type256>
{
    private Type256(string value) : base(value)
    {
    }

    public static readonly Type256 PlLocal = new("plLocal");

    public static Type256 FromValue(string value) => FromValueCore(value);
}
