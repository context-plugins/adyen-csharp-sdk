using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>platformPayment</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type63>))]
public sealed record Type63 : OpenStringEnum<Type63>
{
    private Type63(string value) : base(value)
    {
    }

    public static readonly Type63 PlatformPayment = new("platformPayment");

    public TResult Match<TResult>(Func<TResult> onPlatformPayment, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PlatformPayment => onPlatformPayment(),
            _ => otherwise(Value)
        };

    public void Match(Action onPlatformPayment, Action<string> otherwise)
    {
        if (this == PlatformPayment) onPlatformPayment();
        else otherwise(Value);
    }
}
