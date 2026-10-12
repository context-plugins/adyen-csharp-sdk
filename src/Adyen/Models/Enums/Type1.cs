using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>affirm</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : OpenStringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Affirm = new("affirm");

    public TResult Match<TResult>(Func<TResult> onAffirm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Affirm => onAffirm(),
            _ => otherwise(Value)
        };

    public void Match(Action onAffirm, Action<string> otherwise)
    {
        if (this == Affirm) onAffirm();
        else otherwise(Value);
    }
}
