using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>eft</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type30>))]
public sealed record Type30 : OpenStringEnum<Type30>
{
    private Type30(string value) : base(value)
    {
    }

    public static readonly Type30 EftDirectdebitCa = new("eft_directdebit_CA");

    public TResult Match<TResult>(Func<TResult> onEftDirectdebitCa, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EftDirectdebitCa => onEftDirectdebitCa(),
            _ => otherwise(Value)
        };

    public void Match(Action onEftDirectdebitCa, Action<string> otherwise)
    {
        if (this == EftDirectdebitCa) onEftDirectdebitCa();
        else otherwise(Value);
    }
}
