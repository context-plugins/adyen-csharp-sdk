using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Alignment of the text string on the display line or print line. Absence of this data element means the characters have normal alignment.
/// Possible values:
/// * <b>Centred</b>
/// * <b>Justified</b>
/// * <b>Left</b>
/// * <b>Right</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Alignment1>))]
public sealed record Alignment1 : OpenStringEnum<Alignment1>
{
    private Alignment1(string value) : base(value)
    {
    }

    public static readonly Alignment1 Left = new("Left");

    public static readonly Alignment1 Right = new("Right");

    public static readonly Alignment1 Centred = new("Centred");

    public static readonly Alignment1 Justified = new("Justified");

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
