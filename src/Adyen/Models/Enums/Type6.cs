using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>androidpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : OpenStringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 Androidpay = new("androidpay");

    public TResult Match<TResult>(Func<TResult> onAndroidpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Androidpay => onAndroidpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAndroidpay, Action<string> otherwise)
    {
        if (this == Androidpay) onAndroidpay();
        else otherwise(Value);
    }
}
