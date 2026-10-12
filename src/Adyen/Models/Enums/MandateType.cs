using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MandateType>))]
public sealed record MandateType : OpenStringEnum<MandateType>
{
    private MandateType(string value) : base(value)
    {
    }

    public static readonly MandateType Bacs = new("bacs");

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
