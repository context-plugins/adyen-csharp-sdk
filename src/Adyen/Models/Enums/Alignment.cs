using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Left</b>
/// * <b>Right</b>
/// * <b>Centred</b>
/// * <b>Justified</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Alignment>))]
public sealed record Alignment : OpenStringEnum<Alignment>
{
    private Alignment(string value) : base(value)
    {
    }

    public static readonly Alignment Left = new("Left");

    public static readonly Alignment Right = new("Right");

    public static readonly Alignment Centred = new("Centred");

    public static readonly Alignment Justified = new("Justified");

    public TResult Match<TResult>(Func<TResult> onLeft,
        Func<TResult> onRight,
        Func<TResult> onCentred,
        Func<TResult> onJustified,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Left => onLeft(),
            _ when this == Right => onRight(),
            _ when this == Centred => onCentred(),
            _ when this == Justified => onJustified(),
            _ => otherwise(Value)
        };

    public void Match(Action onLeft, Action onRight, Action onCentred, Action onJustified, Action<string> otherwise)
    {
        if (this == Left) onLeft();
        else if (this == Right) onRight();
        else if (this == Centred) onCentred();
        else if (this == Justified) onJustified();
        else otherwise(Value);
    }
}
