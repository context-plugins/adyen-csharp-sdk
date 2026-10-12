using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paybybank_pix</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type45>))]
public sealed record Type45 : OpenStringEnum<Type45>
{
    private Type45(string value) : base(value)
    {
    }

    public static readonly Type45 PaybybankPix = new("paybybank_pix");

    public TResult Match<TResult>(Func<TResult> onPaybybankPix, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PaybybankPix => onPaybybankPix(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaybybankPix, Action<string> otherwise)
    {
        if (this == PaybybankPix) onPaybybankPix();
        else otherwise(Value);
    }
}
