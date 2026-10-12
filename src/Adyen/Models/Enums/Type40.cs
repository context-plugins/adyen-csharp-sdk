using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paypay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type40>))]
public sealed record Type40 : OpenStringEnum<Type40>
{
    private Type40(string value) : base(value)
    {
    }

    public static readonly Type40 Paypay = new("paypay");

    public TResult Match<TResult>(Func<TResult> onPaypay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Paypay => onPaypay(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaypay, Action<string> otherwise)
    {
        if (this == Paypay) onPaypay();
        else otherwise(Value);
    }
}
