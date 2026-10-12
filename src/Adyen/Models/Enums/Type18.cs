using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Default payment method details. Common for scheme payment methods, and for simple payment method details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type18>))]
public sealed record Type18 : OpenStringEnum<Type18>
{
    private Type18(string value) : base(value)
    {
    }

    public static readonly Type18 Scheme = new("scheme");

    public TResult Match<TResult>(Func<TResult> onScheme, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Scheme => onScheme(),
            _ => otherwise(Value)
        };

    public void Match(Action onScheme, Action<string> otherwise)
    {
        if (this == Scheme) onScheme();
        else otherwise(Value);
    }
}
