using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>afterpay_default</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : StringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 AfterpayDefault = new("afterpay_default");

    public static readonly Type2 Afterpaytouch = new("afterpaytouch");

    public static readonly Type2 AfterpayB2B = new("afterpay_b2b");

    public static readonly Type2 Clearpay = new("clearpay");

    public static Type2 FromValue(string value) => FromValueCore(value);
}
