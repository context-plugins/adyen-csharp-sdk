using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Typographic style of the sequence of characters to display or print. Absence of this data element means the characters have normal style.
/// Possible values:
/// * <b>Bold</b>
/// * <b>Italic</b>
/// * <b>Normal</b>
/// * <b>Underline</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterStyle1>))]
public sealed record CharacterStyle1 : OpenStringEnum<CharacterStyle1>
{
    private CharacterStyle1(string value) : base(value)
    {
    }

    public static readonly CharacterStyle1 Normal = new("Normal");

    public static readonly CharacterStyle1 Bold = new("Bold");

    public static readonly CharacterStyle1 Italic = new("Italic");

    public static readonly CharacterStyle1 Underline = new("Underline");

    public TResult Match<TResult>(Func<TResult> onNormal,
        Func<TResult> onBold,
        Func<TResult> onItalic,
        Func<TResult> onUnderline,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Normal => onNormal(),
            _ when this == Bold => onBold(),
            _ when this == Italic => onItalic(),
            _ when this == Underline => onUnderline(),
            _ => otherwise(Value)
        };

    public void Match(Action onNormal, Action onBold, Action onItalic, Action onUnderline, Action<string> otherwise)
    {
        if (this == Normal) onNormal();
        else if (this == Bold) onBold();
        else if (this == Italic) onItalic();
        else if (this == Underline) onUnderline();
        else otherwise(Value);
    }
}
