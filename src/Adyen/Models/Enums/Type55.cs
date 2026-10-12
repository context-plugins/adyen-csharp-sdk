using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>visacheckout</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type55>))]
public sealed record Type55 : OpenStringEnum<Type55>
{
    private Type55(string value) : base(value)
    {
    }

    public static readonly Type55 Visacheckout = new("visacheckout");

    public TResult Match<TResult>(Func<TResult> onVisacheckout, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Visacheckout => onVisacheckout(),
            _ => otherwise(Value)
        };

    public void Match(Action onVisacheckout, Action<string> otherwise)
    {
        if (this == Visacheckout) onVisacheckout();
        else otherwise(Value);
    }
}
