using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>usLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type283>))]
public sealed record Type283 : StringEnum<Type283>
{
    private Type283(string value) : base(value)
    {
    }

    public static readonly Type283 UsLocal = new("usLocal");

    public static Type283 FromValue(string value) => FromValueCore(value);
}
