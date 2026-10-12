using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>blik</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type13>))]
public sealed record Type13 : OpenStringEnum<Type13>
{
    private Type13(string value) : base(value)
    {
    }

    public static readonly Type13 Blik = new("blik");

    public TResult Match<TResult>(Func<TResult> onBlik, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Blik => onBlik(),
            _ => otherwise(Value)
        };

    public void Match(Action onBlik, Action<string> otherwise)
    {
        if (this == Blik) onBlik();
        else otherwise(Value);
    }
}
