using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>samsungpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type50>))]
public sealed record Type50 : OpenStringEnum<Type50>
{
    private Type50(string value) : base(value)
    {
    }

    public static readonly Type50 Samsungpay = new("samsungpay");

    public TResult Match<TResult>(Func<TResult> onSamsungpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Samsungpay => onSamsungpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onSamsungpay, Action<string> otherwise)
    {
        if (this == Samsungpay) onSamsungpay();
        else otherwise(Value);
    }
}
