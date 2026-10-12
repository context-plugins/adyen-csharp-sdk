using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>vipps</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type54>))]
public sealed record Type54 : OpenStringEnum<Type54>
{
    private Type54(string value) : base(value)
    {
    }

    public static readonly Type54 Vipps = new("vipps");

    public TResult Match<TResult>(Func<TResult> onVipps, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Vipps => onVipps(),
            _ => otherwise(Value)
        };

    public void Match(Action onVipps, Action<string> otherwise)
    {
        if (this == Vipps) onVipps();
        else otherwise(Value);
    }
}
