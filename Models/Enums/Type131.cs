using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>blik</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type131>))]
public sealed record Type131 : StringEnum<Type131>
{
    private Type131(string value) : base(value)
    {
    }

    public static readonly Type131 Blik = new("blik");

    public static Type131 FromValue(string value) => FromValueCore(value);
}
