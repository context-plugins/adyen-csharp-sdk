using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type53>))]
public sealed record Type53 : OpenStringEnum<Type53>
{
    private Type53(string value) : base(value)
    {
    }

    public static readonly Type53 Twint = new("twint");

    public TResult Match<TResult>(Func<TResult> onTwint, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Twint => onTwint(),
            _ => otherwise(Value)
        };

    public void Match(Action onTwint, Action<string> otherwise)
    {
        if (this == Twint) onTwint();
        else otherwise(Value);
    }
}
