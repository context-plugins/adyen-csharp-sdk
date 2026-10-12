using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>bank</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type310>))]
public sealed record Type310 : OpenStringEnum<Type310>
{
    private Type310(string value) : base(value)
    {
    }

    public static readonly Type310 Bank = new("bank");

    public TResult Match<TResult>(Func<TResult> onBank, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bank => onBank(),
            _ => otherwise(Value)
        };

    public void Match(Action onBank, Action<string> otherwise)
    {
        if (this == Bank) onBank();
        else otherwise(Value);
    }
}
