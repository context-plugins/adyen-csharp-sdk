using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>aupay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : OpenStringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 Aupay = new("aupay");

    public TResult Match<TResult>(Func<TResult> onAupay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Aupay => onAupay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAupay, Action<string> otherwise)
    {
        if (this == Aupay) onAupay();
        else otherwise(Value);
    }
}
