using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>rakutenpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type47>))]
public sealed record Type47 : StringEnum<Type47>
{
    private Type47(string value) : base(value)
    {
    }

    public static readonly Type47 Rakutenpay = new("rakutenpay");

    public static Type47 FromValue(string value) => FromValueCore(value);
}
