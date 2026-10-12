using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>mobilepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type37>))]
public sealed record Type37 : OpenStringEnum<Type37>
{
    private Type37(string value) : base(value)
    {
    }

    public static readonly Type37 Mobilepay = new("mobilepay");

    public TResult Match<TResult>(Func<TResult> onMobilepay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mobilepay => onMobilepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onMobilepay, Action<string> otherwise)
    {
        if (this == Mobilepay) onMobilepay();
        else otherwise(Value);
    }
}
