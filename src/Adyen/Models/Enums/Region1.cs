using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The region of operation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region1>))]
public sealed record Region1 : OpenStringEnum<Region1>
{
    private Region1(string value) : base(value)
    {
    }

    public static readonly Region1 Au = new("AU");

    public static readonly Region1 Ch = new("CH");

    public static readonly Region1 Eu = new("EU");

    public static readonly Region1 Na = new("NA");

    public TResult Match<TResult>(Func<TResult> onAu,
        Func<TResult> onCh,
        Func<TResult> onEu,
        Func<TResult> onNa,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Au => onAu(),
            _ when this == Ch => onCh(),
            _ when this == Eu => onEu(),
            _ when this == Na => onNa(),
            _ => otherwise(Value)
        };

    public void Match(Action onAu, Action onCh, Action onEu, Action onNa, Action<string> otherwise)
    {
        if (this == Au) onAu();
        else if (this == Ch) onCh();
        else if (this == Eu) onEu();
        else if (this == Na) onNa();
        else otherwise(Value);
    }
}
