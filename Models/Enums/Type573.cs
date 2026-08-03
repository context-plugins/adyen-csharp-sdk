using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>redirect</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type573>))]
public sealed record Type573 : StringEnum<Type573>
{
    private Type573(string value) : base(value)
    {
    }

    public static readonly Type573 Redirect = new("redirect");

    public static Type573 FromValue(string value) => FromValueCore(value);
}
