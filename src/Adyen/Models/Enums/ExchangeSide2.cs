using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The operation performed on the source amount. Possible values:
/// * <b>buy</b>
/// * <b>sell</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExchangeSide2>))]
public sealed record ExchangeSide2 : OpenStringEnum<ExchangeSide2>
{
    private ExchangeSide2(string value) : base(value)
    {
    }

    public static readonly ExchangeSide2 Buy = new("buy");

    public static readonly ExchangeSide2 Sell = new("sell");

    public TResult Match<TResult>(Func<TResult> onBuy, Func<TResult> onSell, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Buy => onBuy(),
            _ when this == Sell => onSell(),
            _ => otherwise(Value)
        };

    public void Match(Action onBuy, Action onSell, Action<string> otherwise)
    {
        if (this == Buy) onBuy();
        else if (this == Sell) onSell();
        else otherwise(Value);
    }
}
