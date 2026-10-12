using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>mbway</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type36>))]
public sealed record Type36 : OpenStringEnum<Type36>
{
    private Type36(string value) : base(value)
    {
    }

    public static readonly Type36 Mbway = new("mbway");

    public TResult Match<TResult>(Func<TResult> onMbway, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mbway => onMbway(),
            _ => otherwise(Value)
        };

    public void Match(Action onMbway, Action<string> otherwise)
    {
        if (this == Mbway) onMbway();
        else otherwise(Value);
    }
}
