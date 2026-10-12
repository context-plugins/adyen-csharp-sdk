using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>directdebit_GB</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type10>))]
public sealed record Type10 : OpenStringEnum<Type10>
{
    private Type10(string value) : base(value)
    {
    }

    public static readonly Type10 DirectdebitGb = new("directdebit_GB");

    public TResult Match<TResult>(Func<TResult> onDirectdebitGb, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DirectdebitGb => onDirectdebitGb(),
            _ => otherwise(Value)
        };

    public void Match(Action onDirectdebitGb, Action<string> otherwise)
    {
        if (this == DirectdebitGb) onDirectdebitGb();
        else otherwise(Value);
    }
}
