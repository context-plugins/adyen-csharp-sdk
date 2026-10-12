using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>payto</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type41>))]
public sealed record Type41 : OpenStringEnum<Type41>
{
    private Type41(string value) : base(value)
    {
    }

    public static readonly Type41 Payto = new("payto");

    public TResult Match<TResult>(Func<TResult> onPayto, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Payto => onPayto(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayto, Action<string> otherwise)
    {
        if (this == Payto) onPayto();
        else otherwise(Value);
    }
}
