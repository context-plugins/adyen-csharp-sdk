using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// cashapp
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type16>))]
public sealed record Type16 : OpenStringEnum<Type16>
{
    private Type16(string value) : base(value)
    {
    }

    public static readonly Type16 Cashapp = new("cashapp");

    public TResult Match<TResult>(Func<TResult> onCashapp, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cashapp => onCashapp(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashapp, Action<string> otherwise)
    {
        if (this == Cashapp) onCashapp();
        else otherwise(Value);
    }
}
