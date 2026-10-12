using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ancv</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : OpenStringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 Ancv = new("ancv");

    public TResult Match<TResult>(Func<TResult> onAncv, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ancv => onAncv(),
            _ => otherwise(Value)
        };

    public void Match(Action onAncv, Action<string> otherwise)
    {
        if (this == Ancv) onAncv();
        else otherwise(Value);
    }
}
