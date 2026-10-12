using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// When set to true, you can retry for failed recurring payments. The default value is true.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RetryPolicy>))]
public sealed record RetryPolicy : OpenStringEnum<RetryPolicy>
{
    private RetryPolicy(string value) : base(value)
    {
    }

    public static readonly RetryPolicy True = new("true");

    public static readonly RetryPolicy False = new("false");

    public TResult Match<TResult>(Func<TResult> onTrue, Func<TResult> onFalse, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == True => onTrue(),
            _ when this == False => onFalse(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrue, Action onFalse, Action<string> otherwise)
    {
        if (this == True) onTrue();
        else if (this == False) onFalse();
        else otherwise(Value);
    }
}
