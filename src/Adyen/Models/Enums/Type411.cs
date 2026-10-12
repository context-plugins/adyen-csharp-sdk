using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>internal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type411>))]
public sealed record Type411 : OpenStringEnum<Type411>
{
    private Type411(string value) : base(value)
    {
    }

    public static readonly Type411 Internal = new("internal");

    public TResult Match<TResult>(Func<TResult> onInternal, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Internal => onInternal(),
            _ => otherwise(Value)
        };

    public void Match(Action onInternal, Action<string> otherwise)
    {
        if (this == Internal) onInternal();
        else otherwise(Value);
    }
}
