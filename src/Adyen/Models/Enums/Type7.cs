using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>applepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : OpenStringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 Applepay = new("applepay");

    public TResult Match<TResult>(Func<TResult> onApplepay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Applepay => onApplepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplepay, Action<string> otherwise)
    {
        if (this == Applepay) onApplepay();
        else otherwise(Value);
    }
}
