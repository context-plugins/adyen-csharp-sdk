using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>rakutenpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type47>))]
public sealed record Type47 : OpenStringEnum<Type47>
{
    private Type47(string value) : base(value)
    {
    }

    public static readonly Type47 Rakutenpay = new("rakutenpay");

    public TResult Match<TResult>(Func<TResult> onRakutenpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Rakutenpay => onRakutenpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onRakutenpay, Action<string> otherwise)
    {
        if (this == Rakutenpay) onRakutenpay();
        else otherwise(Value);
    }
}
