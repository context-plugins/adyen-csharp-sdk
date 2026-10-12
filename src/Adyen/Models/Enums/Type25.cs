using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ideal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type25>))]
public sealed record Type25 : OpenStringEnum<Type25>
{
    private Type25(string value) : base(value)
    {
    }

    public static readonly Type25 Ideal = new("ideal");

    public TResult Match<TResult>(Func<TResult> onIdeal, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ideal => onIdeal(),
            _ => otherwise(Value)
        };

    public void Match(Action onIdeal, Action<string> otherwise)
    {
        if (this == Ideal) onIdeal();
        else otherwise(Value);
    }
}
