using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Character height of the text string to display or print. Absence of this data element means the characters have normal height.
/// Possible values:
/// * <b>DoubleHeight</b>
/// * <b>HalfHeight</b>
/// * <b>SingleHeight</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterHeight1>))]
public sealed record CharacterHeight1 : OpenStringEnum<CharacterHeight1>
{
    private CharacterHeight1(string value) : base(value)
    {
    }

    public static readonly CharacterHeight1 SingleHeight = new("SingleHeight");

    public static readonly CharacterHeight1 DoubleHeight = new("DoubleHeight");

    public static readonly CharacterHeight1 HalfHeight = new("HalfHeight");

    public TResult Match<TResult>(Func<TResult> onSingleHeight,
        Func<TResult> onDoubleHeight,
        Func<TResult> onHalfHeight,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SingleHeight => onSingleHeight(),
            _ when this == DoubleHeight => onDoubleHeight(),
            _ when this == HalfHeight => onHalfHeight(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingleHeight, Action onDoubleHeight, Action onHalfHeight, Action<string> otherwise)
    {
        if (this == SingleHeight) onSingleHeight();
        else if (this == DoubleHeight) onDoubleHeight();
        else if (this == HalfHeight) onHalfHeight();
        else otherwise(Value);
    }
}
