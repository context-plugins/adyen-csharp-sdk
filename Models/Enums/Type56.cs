using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>wechatpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type56>))]
public sealed record Type56 : StringEnum<Type56>
{
    private Type56(string value) : base(value)
    {
    }

    public static readonly Type56 Wechatpay = new("wechatpay");

    public static readonly Type56 WechatpayPos = new("wechatpay_pos");

    public static Type56 FromValue(string value) => FromValueCore(value);
}
