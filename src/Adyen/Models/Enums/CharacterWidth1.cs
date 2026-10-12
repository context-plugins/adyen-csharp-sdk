using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Character width of the text string to display or print. Absence of this data element means the characters have normal width.
/// Possible values:
/// * <b>DoubleWidth</b>
/// * <b>SingleWidth</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterWidth1>))]
public sealed record CharacterWidth1 : OpenStringEnum<CharacterWidth1>
{
    private CharacterWidth1(string value) : base(value)
    {
    }

    public static readonly CharacterWidth1 SingleWidth = new("SingleWidth");

    public static readonly CharacterWidth1 DoubleWidth = new("DoubleWidth");

    public TResult Match<TResult>(Func<TResult> onSingleWidth,
        Func<TResult> onDoubleWidth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SingleWidth => onSingleWidth(),
            _ when this == DoubleWidth => onDoubleWidth(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingleWidth, Action onDoubleWidth, Action<string> otherwise)
    {
        if (this == SingleWidth) onSingleWidth();
        else if (this == DoubleWidth) onDoubleWidth();
        else otherwise(Value);
    }
}
