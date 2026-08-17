using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>bank</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type310>))]
public sealed record Type310 : StringEnum<Type310>
{
    private Type310(string value) : base(value)
    {
    }

    public static readonly Type310 Bank = new("bank");

    public static Type310 FromValue(string value) => FromValueCore(value);
}
