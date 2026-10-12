using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of mandate. Possible value: <b>bacs</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MandateType2>))]
public sealed record MandateType2 : OpenStringEnum<MandateType2>
{
    private MandateType2(string value) : base(value)
    {
    }

    public static readonly MandateType2 Bacs = new("bacs");

    public TResult Match<TResult>(Func<TResult> onBacs, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bacs => onBacs(),
            _ => otherwise(Value)
        };

    public void Match(Action onBacs, Action<string> otherwise)
    {
        if (this == Bacs) onBacs();
        else otherwise(Value);
    }
}
