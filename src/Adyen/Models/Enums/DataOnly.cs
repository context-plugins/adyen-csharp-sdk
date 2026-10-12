using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/data-only/">data-only flow</see>. When set to <b>true</b>, forces the 3D Secure 2 data-only flow for all transactions where it is possible.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DataOnly>))]
public sealed record DataOnly : OpenStringEnum<DataOnly>
{
    private DataOnly(string value) : base(value)
    {
    }

    public static readonly DataOnly False = new("false");

    public static readonly DataOnly True = new("true");

    public TResult Match<TResult>(Func<TResult> onFalse, Func<TResult> onTrue, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == False => onFalse(),
            _ when this == True => onTrue(),
            _ => otherwise(Value)
        };

    public void Match(Action onFalse, Action onTrue, Action<string> otherwise)
    {
        if (this == False) onFalse();
        else if (this == True) onTrue();
        else otherwise(Value);
    }
}
