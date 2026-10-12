using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The Secure Remote Commerce scheme.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Scheme>))]
public sealed record Scheme : OpenStringEnum<Scheme>
{
    private Scheme(string value) : base(value)
    {
    }

    public static readonly Scheme Mc = new("mc");

    public static readonly Scheme Visa = new("visa");

    public TResult Match<TResult>(Func<TResult> onMc, Func<TResult> onVisa, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mc => onMc(),
            _ when this == Visa => onVisa(),
            _ => otherwise(Value)
        };

    public void Match(Action onMc, Action onVisa, Action<string> otherwise)
    {
        if (this == Mc) onMc();
        else if (this == Visa) onVisa();
        else otherwise(Value);
    }
}
