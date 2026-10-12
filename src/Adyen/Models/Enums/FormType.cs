using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FormType>))]
public sealed record FormType : OpenStringEnum<FormType>
{
    private FormType(string value) : base(value)
    {
    }

    public static readonly FormType Us1099K = new("US1099k");

    public static readonly FormType Us1099Nec = new("US1099nec");

    public TResult Match<TResult>(Func<TResult> onUs1099K,
        Func<TResult> onUs1099Nec,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Us1099K => onUs1099K(),
            _ when this == Us1099Nec => onUs1099Nec(),
            _ => otherwise(Value)
        };

    public void Match(Action onUs1099K, Action onUs1099Nec, Action<string> otherwise)
    {
        if (this == Us1099K) onUs1099K();
        else if (this == Us1099Nec) onUs1099Nec();
        else otherwise(Value);
    }
}
