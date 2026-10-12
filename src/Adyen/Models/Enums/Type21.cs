using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the delivery method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type21>))]
public sealed record Type21 : OpenStringEnum<Type21>
{
    private Type21(string value) : base(value)
    {
    }

    public static readonly Type21 Shipping = new("Shipping");

    public TResult Match<TResult>(Func<TResult> onShipping, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Shipping => onShipping(),
            _ => otherwise(Value)
        };

    public void Match(Action onShipping, Action<string> otherwise)
    {
        if (this == Shipping) onShipping();
        else otherwise(Value);
    }
}
