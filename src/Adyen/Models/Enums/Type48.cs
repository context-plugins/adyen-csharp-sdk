using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ratepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type48>))]
public sealed record Type48 : OpenStringEnum<Type48>
{
    private Type48(string value) : base(value)
    {
    }

    public static readonly Type48 Ratepay = new("ratepay");

    public static readonly Type48 RatepayDirectdebit = new("ratepay_directdebit");

    public TResult Match<TResult>(Func<TResult> onRatepay,
        Func<TResult> onRatepayDirectdebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ratepay => onRatepay(),
            _ when this == RatepayDirectdebit => onRatepayDirectdebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onRatepay, Action onRatepayDirectdebit, Action<string> otherwise)
    {
        if (this == Ratepay) onRatepay();
        else if (this == RatepayDirectdebit) onRatepayDirectdebit();
        else otherwise(Value);
    }
}
