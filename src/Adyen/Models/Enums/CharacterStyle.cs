using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Normal</b>
/// * <b>Bold</b>
/// * <b>Italic</b>
/// * <b>Underline</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterStyle>))]
public sealed record CharacterStyle : OpenStringEnum<CharacterStyle>
{
    private CharacterStyle(string value) : base(value)
    {
    }

    public static readonly CharacterStyle Normal = new("Normal");

    public static readonly CharacterStyle Bold = new("Bold");

    public static readonly CharacterStyle Italic = new("Italic");

    public static readonly CharacterStyle Underline = new("Underline");

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
