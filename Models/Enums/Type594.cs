using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type594>))]
public sealed record Type594 : StringEnum<Type594>
{
    private Type594(string value) : base(value)
    {
    }

    public static readonly Type594 Voucher = new("voucher");

    public static Type594 FromValue(string value) => FromValueCore(value);
}
