using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The region of operation. For example, <b>NA</b>, <b>EU</b>, <b>CH</b>, <b>AU</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region>))]
public sealed record Region : OpenStringEnum<Region>
{
    private Region(string value) : base(value)
    {
    }

    public static readonly Region Na = new("NA");

    public static readonly Region Eu = new("EU");

    public static readonly Region Ch = new("CH");

    public static readonly Region Au = new("AU");

    public TResult Match<TResult>(Func<TResult> onNa,
        Func<TResult> onEu,
        Func<TResult> onCh,
        Func<TResult> onAu,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Na => onNa(),
            _ when this == Eu => onEu(),
            _ when this == Ch => onCh(),
            _ when this == Au => onAu(),
            _ => otherwise(Value)
        };

    public void Match(Action onNa, Action onEu, Action onCh, Action onAu, Action<string> otherwise)
    {
        if (this == Na) onNa();
        else if (this == Eu) onEu();
        else if (this == Ch) onCh();
        else if (this == Au) onAu();
        else otherwise(Value);
    }
}
