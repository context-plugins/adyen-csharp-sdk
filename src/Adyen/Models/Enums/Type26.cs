using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paywithgoogle</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type26>))]
public sealed record Type26 : OpenStringEnum<Type26>
{
    private Type26(string value) : base(value)
    {
    }

    public static readonly Type26 Paywithgoogle = new("paywithgoogle");

    public TResult Match<TResult>(Func<TResult> onPaywithgoogle, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Paywithgoogle => onPaywithgoogle(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaywithgoogle, Action<string> otherwise)
    {
        if (this == Paywithgoogle) onPaywithgoogle();
        else otherwise(Value);
    }
}
