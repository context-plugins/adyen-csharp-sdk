using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SingleWidth</b>
/// * <b>DoubleWidth</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterWidth>))]
public sealed record CharacterWidth : OpenStringEnum<CharacterWidth>
{
    private CharacterWidth(string value) : base(value)
    {
    }

    public static readonly CharacterWidth SingleWidth = new("SingleWidth");

    public static readonly CharacterWidth DoubleWidth = new("DoubleWidth");

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
