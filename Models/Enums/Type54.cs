using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>vipps</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type54>))]
public sealed record Type54 : StringEnum<Type54>
{
    private Type54(string value) : base(value)
    {
    }

    public static readonly Type54 Vipps = new("vipps");

    public static Type54 FromValue(string value) => FromValueCore(value);
}
