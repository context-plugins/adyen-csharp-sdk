using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>samsungpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type50>))]
public sealed record Type50 : StringEnum<Type50>
{
    private Type50(string value) : base(value)
    {
    }

    public static readonly Type50 Samsungpay = new("samsungpay");

    public static Type50 FromValue(string value) => FromValueCore(value);
}
