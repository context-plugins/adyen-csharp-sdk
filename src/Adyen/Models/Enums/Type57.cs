using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>wechatpayMiniProgram</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type57>))]
public sealed record Type57 : OpenStringEnum<Type57>
{
    private Type57(string value) : base(value)
    {
    }

    public static readonly Type57 WechatpayMiniProgram = new("wechatpayMiniProgram");

    public TResult Match<TResult>(Func<TResult> onWechatpayMiniProgram, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == WechatpayMiniProgram => onWechatpayMiniProgram(),
            _ => otherwise(Value)
        };

    public void Match(Action onWechatpayMiniProgram, Action<string> otherwise)
    {
        if (this == WechatpayMiniProgram) onWechatpayMiniProgram();
        else otherwise(Value);
    }
}
