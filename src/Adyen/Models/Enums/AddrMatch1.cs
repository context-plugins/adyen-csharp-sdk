using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the cardholder shipping Address and cardholder billing address are the same. Allowed values:
/// * <b>Y</b> — Shipping Address matches Billing Address.
/// * <b>N</b> — Shipping Address does not match Billing Address.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AddrMatch1>))]
public sealed record AddrMatch1 : OpenStringEnum<AddrMatch1>
{
    private AddrMatch1(string value) : base(value)
    {
    }

    public static readonly AddrMatch1 Y = new("Y");

    public static readonly AddrMatch1 N = new("N");

    public TResult Match<TResult>(Func<TResult> onY, Func<TResult> onN, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Y => onY(),
            _ when this == N => onN(),
            _ => otherwise(Value)
        };

    public void Match(Action onY, Action onN, Action<string> otherwise)
    {
        if (this == Y) onY();
        else if (this == N) onN();
        else otherwise(Value);
    }
}
