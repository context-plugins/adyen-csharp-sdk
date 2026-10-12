using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>amazonpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : OpenStringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Amazonpay = new("amazonpay");

    public TResult Match<TResult>(Func<TResult> onAmazonpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Amazonpay => onAmazonpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmazonpay, Action<string> otherwise)
    {
        if (this == Amazonpay) onAmazonpay();
        else otherwise(Value);
    }
}
