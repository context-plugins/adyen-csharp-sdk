using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value3>))]
public sealed record Value3 : OpenStringEnum<Value3>
{
    private Value3(string value) : base(value)
    {
    }

    public static readonly Value3 AcquirerId = new("acquirerId");

    public static readonly Value3 Amount = new("amount");

    public static readonly Value3 Currency = new("currency");

    public static readonly Value3 MerchantId = new("merchantId");

    public static readonly Value3 MerchantName = new("merchantName");

    public TResult Match<TResult>(Func<TResult> onAcquirerId,
        Func<TResult> onAmount,
        Func<TResult> onCurrency,
        Func<TResult> onMerchantId,
        Func<TResult> onMerchantName,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AcquirerId => onAcquirerId(),
            _ when this == Amount => onAmount(),
            _ when this == Currency => onCurrency(),
            _ when this == MerchantId => onMerchantId(),
            _ when this == MerchantName => onMerchantName(),
            _ => otherwise(Value)
        };

    public void Match(Action onAcquirerId,
        Action onAmount,
        Action onCurrency,
        Action onMerchantId,
        Action onMerchantName,
        Action<string> otherwise)
    {
        if (this == AcquirerId) onAcquirerId();
        else if (this == Amount) onAmount();
        else if (this == Currency) onCurrency();
        else if (this == MerchantId) onMerchantId();
        else if (this == MerchantName) onMerchantName();
        else otherwise(Value);
    }
}
