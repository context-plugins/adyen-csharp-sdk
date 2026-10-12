using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>sepadirectdebit</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type27>))]
public sealed record Type27 : OpenStringEnum<Type27>
{
    private Type27(string value) : base(value)
    {
    }

    public static readonly Type27 Sepadirectdebit = new("sepadirectdebit");

    public TResult Match<TResult>(Func<TResult> onSepadirectdebit, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sepadirectdebit => onSepadirectdebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onSepadirectdebit, Action<string> otherwise)
    {
        if (this == Sepadirectdebit) onSepadirectdebit();
        else otherwise(Value);
    }
}
