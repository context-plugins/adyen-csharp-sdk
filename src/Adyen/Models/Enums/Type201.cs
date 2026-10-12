using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the webhook you are configuring. Set to <b>balance</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type201>))]
public sealed record Type201 : OpenStringEnum<Type201>
{
    private Type201(string value) : base(value)
    {
    }

    public static readonly Type201 Balance = new("balance");

    public TResult Match<TResult>(Func<TResult> onBalance, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Balance => onBalance(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalance, Action<string> otherwise)
    {
        if (this == Balance) onBalance();
        else otherwise(Value);
    }
}
