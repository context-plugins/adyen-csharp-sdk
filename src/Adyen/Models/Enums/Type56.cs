using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>wechatpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type56>))]
public sealed record Type56 : OpenStringEnum<Type56>
{
    private Type56(string value) : base(value)
    {
    }

    public static readonly Type56 Wechatpay = new("wechatpay");

    public static readonly Type56 WechatpayPos = new("wechatpay_pos");

    public TResult Match<TResult>(Func<TResult> onWechatpay,
        Func<TResult> onWechatpayPos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Wechatpay => onWechatpay(),
            _ when this == WechatpayPos => onWechatpayPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onWechatpay, Action onWechatpayPos, Action<string> otherwise)
    {
        if (this == Wechatpay) onWechatpay();
        else if (this == WechatpayPos) onWechatpayPos();
        else otherwise(Value);
    }
}
