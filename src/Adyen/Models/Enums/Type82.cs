using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>sgLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type82>))]
public sealed record Type82 : OpenStringEnum<Type82>
{
    private Type82(string value) : base(value)
    {
    }

    public static readonly Type82 SgLocal = new("sgLocal");

    public TResult Match<TResult>(Func<TResult> onSgLocal, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SgLocal => onSgLocal(),
            _ => otherwise(Value)
        };

    public void Match(Action onSgLocal, Action<string> otherwise)
    {
        if (this == SgLocal) onSgLocal();
        else otherwise(Value);
    }
}
