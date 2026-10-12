using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type44>))]
public sealed record Type44 : OpenStringEnum<Type44>
{
    private Type44(string value) : base(value)
    {
    }

    public static readonly Type44 Pix = new("pix");

    public TResult Match<TResult>(Func<TResult> onPix, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pix => onPix(),
            _ => otherwise(Value)
        };

    public void Match(Action onPix, Action<string> otherwise)
    {
        if (this == Pix) onPix();
        else otherwise(Value);
    }
}
