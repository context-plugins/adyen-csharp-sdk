using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : OpenStringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 Alma = new("alma");

    public TResult Match<TResult>(Func<TResult> onAlma, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Alma => onAlma(),
            _ => otherwise(Value)
        };

    public void Match(Action onAlma, Action<string> otherwise)
    {
        if (this == Alma) onAlma();
        else otherwise(Value);
    }
}
