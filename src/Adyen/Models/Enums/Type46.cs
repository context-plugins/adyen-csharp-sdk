using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type46>))]
public sealed record Type46 : OpenStringEnum<Type46>
{
    private Type46(string value) : base(value)
    {
    }

    public static readonly Type46 PsePayulatam = new("pse_payulatam");

    public TResult Match<TResult>(Func<TResult> onPsePayulatam, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PsePayulatam => onPsePayulatam(),
            _ => otherwise(Value)
        };

    public void Match(Action onPsePayulatam, Action<string> otherwise)
    {
        if (this == PsePayulatam) onPsePayulatam();
        else otherwise(Value);
    }
}
