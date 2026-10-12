using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of string matching operation. Possible values:  <b>startsWith</b>, <b>endsWith</b>, <b>isEqualTo</b>, <b>contains</b>,
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Operation>))]
public sealed record Operation : OpenStringEnum<Operation>
{
    private Operation(string value) : base(value)
    {
    }

    public static readonly Operation Contains = new("contains");

    public static readonly Operation EndsWith = new("endsWith");

    public static readonly Operation IsEqualTo = new("isEqualTo");

    public static readonly Operation StartsWith = new("startsWith");

    public TResult Match<TResult>(Func<TResult> onContains,
        Func<TResult> onEndsWith,
        Func<TResult> onIsEqualTo,
        Func<TResult> onStartsWith,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Contains => onContains(),
            _ when this == EndsWith => onEndsWith(),
            _ when this == IsEqualTo => onIsEqualTo(),
            _ when this == StartsWith => onStartsWith(),
            _ => otherwise(Value)
        };

    public void Match(Action onContains,
        Action onEndsWith,
        Action onIsEqualTo,
        Action onStartsWith,
        Action<string> otherwise)
    {
        if (this == Contains) onContains();
        else if (this == EndsWith) onEndsWith();
        else if (this == IsEqualTo) onIsEqualTo();
        else if (this == StartsWith) onStartsWith();
        else otherwise(Value);
    }
}
