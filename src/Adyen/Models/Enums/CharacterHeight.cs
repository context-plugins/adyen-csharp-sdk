using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SingleHeight</b>
/// * <b>DoubleHeight</b>
/// * <b>HalfHeight</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterHeight>))]
public sealed record CharacterHeight : OpenStringEnum<CharacterHeight>
{
    private CharacterHeight(string value) : base(value)
    {
    }

    public static readonly CharacterHeight SingleHeight = new("SingleHeight");

    public static readonly CharacterHeight DoubleHeight = new("DoubleHeight");

    public static readonly CharacterHeight HalfHeight = new("HalfHeight");

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
