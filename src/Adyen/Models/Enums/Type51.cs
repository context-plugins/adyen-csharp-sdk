using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>sepadirectdebit</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type51>))]
public sealed record Type51 : OpenStringEnum<Type51>
{
    private Type51(string value) : base(value)
    {
    }

    public static readonly Type51 Sepadirectdebit = new("sepadirectdebit");

    public static readonly Type51 SepadirectdebitAmazonpay = new("sepadirectdebit_amazonpay");

    public TResult Match<TResult>(Func<TResult> onSepadirectdebit,
        Func<TResult> onSepadirectdebitAmazonpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sepadirectdebit => onSepadirectdebit(),
            _ when this == SepadirectdebitAmazonpay => onSepadirectdebitAmazonpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onSepadirectdebit, Action onSepadirectdebitAmazonpay, Action<string> otherwise)
    {
        if (this == Sepadirectdebit) onSepadirectdebit();
        else if (this == SepadirectdebitAmazonpay) onSepadirectdebitAmazonpay();
        else otherwise(Value);
    }
}
