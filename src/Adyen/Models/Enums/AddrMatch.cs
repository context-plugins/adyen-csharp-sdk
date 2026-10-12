using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the cardholder shipping address and cardholder billing address are the same. Allowed values:
/// * <b>Y</b> — Shipping address matches billing address.
/// * <b>N</b> — Shipping address does not match billing address.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AddrMatch>))]
public sealed record AddrMatch : OpenStringEnum<AddrMatch>
{
    private AddrMatch(string value) : base(value)
    {
    }

    public static readonly AddrMatch Y = new("Y");

    public static readonly AddrMatch N = new("N");

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
