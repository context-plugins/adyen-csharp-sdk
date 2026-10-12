using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the action.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type19>))]
public sealed record Type19 : OpenStringEnum<Type19>
{
    private Type19(string value) : base(value)
    {
    }

    public static readonly Type19 Sdk = new("sdk");

    public static readonly Type19 WechatpaySdk = new("wechatpaySDK");

    public TResult Match<TResult>(Func<TResult> onSdk, Func<TResult> onWechatpaySdk, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sdk => onSdk(),
            _ when this == WechatpaySdk => onWechatpaySdk(),
            _ => otherwise(Value)
        };

    public void Match(Action onSdk, Action onWechatpaySdk, Action<string> otherwise)
    {
        if (this == Sdk) onSdk();
        else if (this == WechatpaySdk) onWechatpaySdk();
        else otherwise(Value);
    }
}
