using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>afterpay_default</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type22>))]
public sealed record Type22 : StringEnum<Type22>
{
    private Type22(string value) : base(value)
    {
    }

    public static readonly Type22 AfterpayDefault = new("afterpay_default");

    public static readonly Type22 Afterpaytouch = new("afterpaytouch");

    public static readonly Type22 AfterpayB2B = new("afterpay_b2b");

    public static readonly Type22 Clearpay = new("clearpay");

    public static Type22 FromValue(string value) => FromValueCore(value);
}
