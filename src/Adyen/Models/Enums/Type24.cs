using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>googlepay</b>, <b>paywithgoogle</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type24>))]
public sealed record Type24 : OpenStringEnum<Type24>
{
    private Type24(string value) : base(value)
    {
    }

    public static readonly Type24 Googlepay = new("googlepay");

    public TResult Match<TResult>(Func<TResult> onGooglepay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Googlepay => onGooglepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onGooglepay, Action<string> otherwise)
    {
        if (this == Googlepay) onGooglepay();
        else otherwise(Value);
    }
}
